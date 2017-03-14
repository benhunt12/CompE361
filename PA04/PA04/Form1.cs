using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PA04
{
    public partial class Form1 : Form
    {
        public int choice = 0;
        public char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();


        /// <summary>
        /// Goes through a word that has been morphed and computs the morphed of each of those and puts them in a list.
        /// </summary>
        /// <param name="args">command­line args</param>
        /// <returns>The list of all the morphed words for that word</returns>
        public static List<string> Morph(string startWord, string[] lines)
        {
            // This is here so i can access the public WordList
            Form1 MOTO = new Form1();

            List<string> morphIndi = new List<string>();
            // Creates an interger for a sublist and then loops through this, however loops through all strings within this sublist first.
            int subList;
            for (subList = 0; subList < lines.Length; subList++)
            {
                if (lines[subList].Length == startWord.Length)
                {
                    // Sets a check variable to zero each time it enters this if statement
                    int check = 0;

                    // checks all strings within the sublist loop.
                    for (int list = 0; list < startWord.Length; list++)
                    {
                        // If the word doesn't equal the startword
                        if (lines[subList][list] != startWord[list])
                        {
                            // checks to see how many times this loop has ran, if more than once breaks
                            // Else it adds one to the check counter.
                            if (check > 1)
                                break;
                            else
                                check++;
                        }
                    }

                    // After it breaks from the loop and it sees that check is one it will add the string to the list.
                    if (check == 1)
                        morphIndi.Add(lines[subList]);
                }
            }

            // After going through all of this it sends back this MorphIndi list for the word.
            return morphIndi;
        }

        /// <summary>
        /// Uses the Morphed words from the previous method and sees which one match the final word and stores that path into a list
        /// </summary>
        /// <param name="args">command­line args</param>
        /// <returns>The Final list of the morphed words to final word</returns>
        public static List<string> MorphChain(string startWord, string endWord, List<string> morphedList, int Length, string[] send)
        {
            // Creates a function for morhping all the posbilities of a certain word
            List<string> morphIndi = Morph(startWord, send);

            // Adds the start word to the final output list
            morphedList.Add(startWord);

            // Checks to see if the individual morped list has the final word in it if it does it aadds the final word to the final list
            if (morphIndi.Contains(endWord))
            {
                morphedList.Add(endWord);
            }

            // The length is decreesing by 1 each time this function starts. and this checks if the Length has reached zero.
            // If so it will return the final list back to main function
            if (Length == 0)
                return morphedList;

            for (int i = 0; i < morphIndi.Count; i++)
            {
                // Checks to see if any words have been repeated.
                if (!(morphedList.Contains(morphIndi[i])))
                {
                    // If none have, repeates this function
                    MorphChain(morphIndi[i], endWord, morphedList, Length - 1, send);

                    // This Checks to see if the lat word in the list is the end Word. If so it gets out of the loop.
                    // if it isn't it removes the lat word and starts the loop again
                    if (morphedList[((morphedList).Count) - 1] == endWord)
                        break;
                    else
                        morphedList.RemoveAt((morphedList.Count) - 1);
                }
            }
            // Returns the final list.
            return morphedList;
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calls the choice 1 option(List all Words) and disables the three text boxes for starting, ending and length 
        /// </summary>
        /// <param name="args">command­line args</param>
        private void rbtn_PrintAll_CheckedChanged(object sender, EventArgs e)
        {
            choice = 1;
            this.starting.Enabled = false;
            this.ending.Enabled = false;
            this.chainLength.Enabled = false;
        }

        /// <summary>
        /// Calls the choice 2 option(Rhyming Words) and disables the two text boxes for ending and length 
        /// </summary>
        /// <param name="args">command­line args</param>
        private void rbtn_Ryhming_CheckedChanged(object sender, EventArgs e)
        {
            choice = 2;
            this.starting.Enabled = true;
            this.ending.Enabled = false;
            this.chainLength.Enabled = false;
        }

        /// <summary>
        /// Calls the choice 3 option(Scrabble) and disables the two text boxes for ending and length 
        /// </summary>
        /// <param name="args">command­line args</param>
        private void rbtn_Scrabble_CheckedChanged(object sender, EventArgs e)
        {
            choice = 3;
            this.starting.Enabled = true;
            this.ending.Enabled = false;
            this.chainLength.Enabled = false;
        }

        /// <summary>
        /// Calls the choice 4 option(Morph Words) and disables the two text boxes for ending and length 
        /// </summary>
        /// <param name="args">command­line args</param>
        private void rbtn_Morph_CheckedChanged(object sender, EventArgs e)
        {
            choice = 4;
            this.starting.Enabled = true;
            this.ending.Enabled = false;
            this.chainLength.Enabled = false;
        }

        /// <summary>
        /// Calls the choice 5 option(Morph Chain) and enables all text boxes.
        /// </summary>
        /// <param name="args">command­line args</param>
        private void rbtn_MorphChain_CheckedChanged(object sender, EventArgs e)
        {
            choice = 5;
            this.starting.Enabled = true;
            this.ending.Enabled = true;
            this.chainLength.Enabled = true;
        }

        /// <summary>
        /// The purpose of this program was be able to access and parse a txt file.
        /// The Program reads in a text file, in our case each line is a different word, the it reads in the text file as an array per line
        /// With this array of strings it asks the user to enter a task that he/she wants to do.
        /// The program should display the user's choices in a menu, and prompt the user for any needed input. 
        /// List of tasks:
        ///     1. list all words
        ///     2. list rhyming words(words that end in a string specified by the user)
        ///     3. list scrabble words(words that are constructed from the letters specified by the user; note that a letter may be used multiple times only if it appears that many times  in the user list)
        ///     4. list morph words(words that differ from a specified word in only one letter)
        ///     5. Morph Chains
        /// </summary>  
        /// <param name="args">command-line args</param>
        private void btn_Fill_Click(object sender, EventArgs e)
        {
            Form1 MOTO = new Form1();

            String[] word_list = Properties.Resources.WordList.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            int count = word_list.Length;

            if (choice == 1)
            {
                DisplayBox.BeginUpdate();
                DisplayBox.Items.Clear();
                foreach (string line in word_list)
                {
                    DisplayBox.Items.Add(line);
                }
                DisplayBox.EndUpdate();
            }

            if (choice == 2)
            {
                //read string from user into desired string
                string desired = starting.Text;
                DisplayBox.Items.Clear();

                // The following simply confirms that the Entered word is actually a word and does not contain numbers or special charecters.
                // If it fails it pops up a message box asking to enter a real word.
                try
                {
                    // Trys to see if the word is an actual word using Regex
                    if (Regex.IsMatch(desired, @"^[a-zA-Z]+$") == false)
                    {
                        // Throws an execption for 'catch' to deal with.
                        throw new Exception();
                    }
                }
                catch
                {
                    // opening the message box.
                    MessageBox.Show("Please enter a real start word.");
                    return;
                }

                for (int i = 0; i < count; i++)
                {
                    if (word_list[i].EndsWith(desired))
                    {
                        DisplayBox.Items.Add(word_list[i]);
                    }
                }
            }

            // This if statement is the scrabble function allowing the user to enter 7 random letters
            // and for the program to find words with those letters.
            if (choice == 3)
            {
                string scrabble = starting.Text;
                int z, y;
                DisplayBox.Items.Clear();

                // The following simply confirms that the Entered word is actually a word and does not contain numbers or special charecters.
                // If it fails it pops up a message box asking to enter a real word.
                try
                {
                    // Trys to see if the word is an actual word using Regex
                    if (Regex.IsMatch(scrabble, @"^[a-zA-Z]+$") == false)
                    {
                        // Throws an execption for 'catch' to deal with.
                        throw new Exception();
                    }
                }
                catch
                {
                    // opening the message box.
                    MessageBox.Show("Please enter a real start word.");
                    return;
                }

                //convert scrabble array into char array so letters can be read individually
                char[] scrabble2 = scrabble.ToCharArray();

                for (int i = 0; i < count; i++)
                {
                    char[] word2 = word_list[i].ToCharArray();
                    int check = 0;

                    if (scrabble.Length >= word_list[i].Length && word_list[i].Length >= 3)
                    {

                        //search through all scrabble cells
                        for (z = 0; z < scrabble.Length; z++)
                        {

                            //search through all wordlist cells
                            for (y = 0; y < word_list[i].Length; y++)
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
                        if (check == word_list[i].Length)
                        {
                            DisplayBox.Items.Add(word_list[i]);
                        }
                    }
                }

            }
            // Choice 4 is the Morph function, which finds all words that are off by only one letter.
            if (choice == 4)
            {
                int y;
                string start = starting.Text;
                DisplayBox.Items.Clear();

                // The following simply confirms that the Entered word is actually a word and does not contain numbers or special charecters.
                // If it fails it pops up a message box asking to enter a real word.
                try
                {
                    // Trys to see if the word is an actual word using Regex
                    if (Regex.IsMatch(start, @"^[a-zA-Z]+$") == false)
                    {
                        // Throws an execption for 'catch' to deal with.
                        throw new Exception();
                    }
                }
                catch
                {
                    // opening the message box.
                    MessageBox.Show("Please enter a real start word.");
                    return;
                }

                //cycle through all the words
                for (int i = 0; i < count; i++)
                {
                    int ctr = 0;

                    //we only want words that are the same length, so check to make sure. If not, move on
                    if (start.Length == word_list[i].Length)
                    {

                        // changing word from wordlist and scrabble string into char array to compare letters individually
                        char[] word = word_list[i].ToCharArray();
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
                            DisplayBox.Items.Add(word_list[i]);
                        }
                    }
                }
            }
            if (choice == 5)
            {
                // The next few lines Simply Have the user input the start, end word and length 

                string startWord = starting.Text;
                string endWord = ending.Text;
                int length = 0;
                DisplayBox.Items.Clear();

                // The following simply confirms that the Entered start word is actually a word and does not contain numbers or special charecters.
                // If it fails it pops up a message box asking to enter a real word.
                try
                {
                    // Trys to see if the word is an actual word using Regex
                    if (Regex.IsMatch(startWord, @"^[a-zA-Z]+$") == false)
                    {
                        // Throws an execption for 'catch' to deal with.
                        throw new Exception();
                    }
                }
                catch
                {
                    // opening the message box.
                    MessageBox.Show("Please enter a real start word.");
                    return;
                }

                // The following simply confirms that the Entered end word is actually a word and does not contain numbers or special charecters.
                // If it fails it pops up a message box asking to enter a real word.
                try
                {
                    // Trys to see if the word is an actual word using Regex
                    if (Regex.IsMatch(endWord, @"^[a-zA-Z]+$") == false)
                    {
                        // Throws an execption for 'catch' to deal with.
                        throw new Exception();
                    }
                }
                catch
                {
                    // opening the message box.
                    MessageBox.Show("Please enter a real end word.");
                    return;
                }

                // The following simply confirms that the start word and end word are of equal length
                // If it fails it pops up a message box asking to enter two words of the same length
                try
                {
                    // Trys to see if the words are of same length
                    if (startWord.Length != endWord.Length)
                    {
                        // Throws an execption for 'catch' to deal with.
                        throw new Exception("The two words are not the same length");
                    }
                }
                catch
                {
                    // opening the message box.
                    MessageBox.Show("Please enter two words of the same length.");
                    return;
                }

                // The following simply confirms that that the length is actually an integer.
                // If it fails it pops up a message box asking to enter an integer
                try
                {
                    // Trys to Parse an integer out of the user input if fails throws an exception for 'catch' to deal with
                    length = int.Parse(chainLength.Text);

                }
                catch
                {
                    // opening the message box.
                    MessageBox.Show("Please enter an integer.");
                    return;
                }

                //makes sure the user enters a reasonalbe value for the length of the morph chain
                try
                {
                    if (length > 10)
                    {
                        throw new Exception("Length is too big.");
                    }
                }
                catch
                {
                    // opening the message box.
                    MessageBox.Show("Please enter an integer less than 10.");
                    return;
                }

                // Subtracts 2 from the length
                length = length - 2;

                //Creates a new list for all the morphed words that lead up to the final word.
                List<string> morphedList = new List<string>();

                // Checks to see if the final word equals to the start word. if it does, it prints both of them.
                if (startWord == endWord)
                {
                    DisplayBox.Items.Add(startWord);
                    DisplayBox.Items.Add(endWord);
                }

                //Calls the morphcahin function that completes the main program.
                MorphChain(startWord, endWord, morphedList, length, word_list);

                // If the length of the morphed list is greater than the length specfied it does not print
                if (morphedList.Count > length + 2)
                {
                    /////////////////Console.WriteLine("No Solution with the given Length or Less");
                }

                //But if it is fine it prints all the strings in morphed list
                else
                {
                    //Loops through all of the words
                    for (int i = 0; i < morphedList.Count; i++)
                    {
                        DisplayBox.Items.Add(morphedList[i]);
                    }
                }

            }


        }

        /// <summary>
        /// Resets the Text Boxes to blanks. In essence Clears the text boxxes.
        /// </summary>
        /// <param name="args">command­line args</param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            starting.Text = String.Empty;
            ending.Text = String.Empty;
            chainLength.Text = String.Empty;
            DisplayBox.Items.Clear();
        }

        /// <summary>
        /// Creates a button for Help, and pops open the following message.
        /// </summary>
        /// <param name="args">command­line args</param>
        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LIST ALL WORDS: Hit 'Fill' to see all the words in the list.\n\n"
                + "RHYMING WORDS: Enter the end of a word you want to ryhme with in the 'Start' box, then hit 'Fill'.\n\n"
                + "SCRABBLE WORDS: Enter some random letters in the 'Start' box, then hit 'Fill'.\n\n"
                + "MORPH WORDS: Enter a word you want morphed in the 'Start' box, then hit 'Fill'. The output will be your word changed by only one letter.\n\n"
                + "MORPH CHAIN: Enter a starting word in the 'Start' box, and an ending word in the 'End' box. Then enter your maximum chain length, and hit'Fill'.\n\n");
        }
    }
}