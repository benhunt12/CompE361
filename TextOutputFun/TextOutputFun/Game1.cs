using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

namespace TextOutputFun
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public const int WindowWidth = 800;
        public const int WindowHeight = 600;
        public int curIndex = 0;
        public int newIndex = 0;

        public MouseState prevMouseState;
        public MouseState mouseState;
        public Vector2 textSize;

        Random rand = new Random();

        public List<string> output = new List<string>();

        SpriteFont font;
  
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

            font = Content.Load<SpriteFont>(@"fonts\Arial");
            
            output.Add("This is output1");
            output.Add("This is output2, a little different");
            output.Add("This is output3, further away");
            output.Add("This is output4, still going");
            output.Add("This is output5, last one");

            curIndex = rand.Next(0, 4);
            textSize = font.MeasureString(output[curIndex]);
            textSize = new Vector2(graphics.PreferredBackBufferWidth - textSize.X, graphics.PreferredBackBufferHeight - textSize.Y);
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

            mouseState = Mouse.GetState();

            if ((mouseState.LeftButton == ButtonState.Pressed) && (prevMouseState.LeftButton == ButtonState.Released))
            {
                while(newIndex == curIndex)
                {
                    newIndex = rand.Next(0, 4);                
                }
                curIndex = newIndex;
                textSize = font.MeasureString(output[curIndex]);
                textSize = new Vector2(graphics.PreferredBackBufferWidth - textSize.X, graphics.PreferredBackBufferHeight - textSize.Y);
            }

            prevMouseState = Mouse.GetState();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.DrawString(font, output[curIndex], textSize, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
