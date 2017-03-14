using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PA02
{

    /// <summary>
    /// Implements PA02 functionality
    /// </summary>
    class Program
    {

        /// <summary>
        /// Executes the following:
        /// 1. Reads .txt file into a list
        /// 2. Prints all words 
        /// 3. Gets word ending from user, then prints all words that end with the same string
        /// 4. Gets random letters from user, prints all word containing those letters. All letters in each word have to be provided by the user
        /// 5. Gets a word from the user, prints all words that are different by only 1 letters, from anywhere in the word
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            
            int i = 0;
            int x = 0;
            string s;

            //This block is to put the file into a list
            List<string> wordList = new List<string>();
            using (StreamReader reader = new StreamReader(@"C:\Users\benja\OneDrive\Documents\Visual Studio 2015\Projects\PA02\WordList.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    wordList.Add(line);
                }
            }

            while (x != 5)
            {
                Console.WriteLine("[1] All Words");
                Console.WriteLine("[2] Rhyming Words");
                Console.WriteLine("[3] Scrabble Words");
                Console.WriteLine("[4] Morph Words");
                Console.WriteLine("[5] Quit");
                Console.Write("Your choice: ");

                s = Console.ReadLine();
                x = int.Parse(s);
                int count = wordList.Count;

                if (x == 1)
                {
                    Console.WriteLine("\n\n");
                    for (i = 0; i < count; i++)
                    {

                        //print wordlist 1, 2, 3......
                        Console.WriteLine("{0}", wordList[i]); 
                    }
                    Console.WriteLine("");
                }

                if (x == 2)
                {
                    Console.WriteLine("\n\n");

                    //read string from user into desired string
                    string desired;
                    Console.Write("Enter desired ending string: ");
                    desired = Console.ReadLine(); 

                    for (i = 0; i < count; i++)
                    {
                        if (wordList[i].EndsWith(desired))
                        {
                            Console.WriteLine("{0}", wordList[i]);
                        }
                    }
                    Console.WriteLine("");
                }

                if (x == 3)
                {
                    Console.WriteLine("\n\n");
                    string scrabble;
                    int z, y;
                    Console.Write("Enter scrabble letters: ");
                    scrabble = Console.ReadLine();

                    //convert scrabble array into char array so letters can be read individually
                    char[] scrabble2 = scrabble.ToCharArray(); 

                    for (i = 0; i < count; i++)
                    {
                        char[] word2 = wordList[i].ToCharArray();
                        int check = 0;

                        if (scrabble.Length >= wordList[i].Length && wordList[i].Length >= 3)
                        {

                            //search through all scrabble cells
                            for (z = 0; z < scrabble.Length; z++)
                            {

                                //search through all wordlist cells
                                for (y = 0; y < wordList[i].Length; y++) 
                                {

                                    //compare scrabble cell 0, to wordlist cell 0. Then scrabble 1, to wordlist 0....
                                    if (word2[y] == scrabble2[z])
                                    {
                                        check = check + 1;
                                        word2[y] = '0';
                                        break;
                                    }
                                }
                            }

                            //if letters matched equal letter of wordlist word, print. Means every letter appeared once in wordlist word
                            if (check == wordList[i].Length) 
                            {
                                Console.WriteLine("{0}", wordList[i]);
                            }
                        }
                    }
                    Console.WriteLine("");
                }


                if (x == 4)
                {
                    Console.WriteLine("\n\n");
                    int y;
                    string start;
                    Console.Write("Enter start word: ");
                    start = Console.ReadLine();

                    //cycle through all the words
                    for (i = 0; i < count; i++)
                    {
                        int ctr = 0;

                        //we only want words that are the same length, so check to make sure. If not, move on
                        if (start.Length == wordList[i].Length) 
                        {

                            // changing word from wordlist and scrabble string into char array to compare letters individually
                            char[] word = wordList[i].ToCharArray();
                            char[] array = start.ToCharArray();

                            //cycle through as many times as long as the string is, compare the two characters, and add 1 to counter to keep track of how many characters match
                            for (y = 0; y < start.Length; y++) 
                            {
                                if (word[y] == array[y])
                                {
                                    ctr = ctr + 1; 
                                }
                            }

                            //if there are atleast two letters that match, print the word
                            if (ctr == (start.Length - 1))  
                            {
                                Console.WriteLine("{0}", wordList[i]);
                            }
                        }
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
