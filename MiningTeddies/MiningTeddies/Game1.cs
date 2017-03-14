using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace MiningTeddies
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch, spriteBatch1, spriteBatch2;

        public const int WindowWidth = 800;
        public const int WindowHeight = 600;
        public int curTime = 0;
        public int initialDelay = 1000;

        Texture2D bearSprite;
        Texture2D exploSprite;
        Texture2D mineSprite;

        Random rand = new Random();

        List<Mine> mines = new List<Mine>();
        List<TeddyBear> bears = new List<TeddyBear>();
        List<Explosion> explos = new List<Explosion>();

        public bool mineDown = false;

        public float speed;
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;

            IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteBatch1 = new SpriteBatch(GraphicsDevice);
            spriteBatch2 = new SpriteBatch(GraphicsDevice);

            bearSprite = Content.Load<Texture2D>(@"Graphics\teddybear");
            mineSprite = Content.Load<Texture2D>(@"Graphics\mine");
            exploSprite = Content.Load<Texture2D>(@"Graphics\explosion");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            MouseState mouse = Mouse.GetState();

            int drawDelay = rand.Next(1000, 3000);
            int width = rand.Next(1, 800);
            int height = rand.Next(1, 600);

            curTime = curTime + gameTime.ElapsedGameTime.Milliseconds;
            Vector2 speed = new Vector2((float)(rand.NextDouble() * 1 - 0.5), (float)(rand.NextDouble() * 1 - 0.5));

            if (curTime >= drawDelay)
            {
                bears.Add(new TeddyBear(bearSprite, speed, width, height));
                curTime = 0;
                initialDelay = drawDelay;
            }

            for (int i = 0; i < bears.Count; i++)
            {
                bears[i].Update(gameTime);
            }

            

            if (mouse.LeftButton == ButtonState.Pressed)
            {
                mineDown = true;
            }

            if((mouse.LeftButton == ButtonState.Released) && (mineDown == true))
            {
                mineDown = false;
                mines.Add(new Mine(mineSprite, mouse.X, mouse.Y));
            }

            
            for (int i = 0; i < bears.Count; i++)
            {
                for (int j = 0; j < mines.Count; j++)
                {
                    if (bears[i].CollisionRectangle.Intersects(mines[j].CollisionRectangle))
                    {
                        explos.Add(new Explosion(exploSprite, mines[j].CollisionRectangle.Center.X, mines[j].CollisionRectangle.Center.Y));

                        mines[j].Active = false;
                        mines.RemoveAt(j);

                        bears[i].Active = false;
                        bears.RemoveAt(i);
                    }
                }
            }

            for (int i = 0; i < explos.Count; i++)
            {
                explos[i].Update(gameTime);
            }



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch1.Begin();
            spriteBatch2.Begin();

            for (int i = 0; i < mines.Count; i++)
            {
                mines[i].Draw(spriteBatch1);
            }
            
            for (int i = 0; i < bears.Count; i++)
            {
                bears[i].Draw(spriteBatch);
            }

            for (int i = 0; i < explos.Count; i++)
            {
                explos[i].Draw(spriteBatch);
                
            }

            spriteBatch.End();
            spriteBatch1.End();
            spriteBatch2.End();

            base.Draw(gameTime);
        }
    }
}
