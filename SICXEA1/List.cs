/* Nathan Aamodt
 * Systems Programming
 * Assign 1
 * Hamer
 * This program will take symbol inputs from symbol.dat create a table using thoes inputs.
 * Then it will search from Test.txt to search for symbols in the table.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SICXEA1
{
    //Class List
    //this class opens the symbols file, then it procceeds to initalize the table and fill the table with the inputed symbols
    //from the  file.
    public class List
    {
        public Symbol[] Table;
        //List() defines the table as well as calls in the functions we need to complete the table.
        // no inputs
        // no outputs
        public List()
        {
            string file = "Symbols.dat";
            Table = new Symbol[CountLinesReader(file)];
            InitializeTable(file);
            CreateList();
        }
        //List
        //copy constructor of List
        //Uses the input of the copy constructor for symbol
        public List(Symbol[] Soul)
        {
            Table = Soul;
        }
        /* Initalize Table
         * This function will initialize the table with the line reader to have an accurate mesure on table length
         * input is the string with the file name in it to be called
         */
        public void InitializeTable(string file)
        {
            for (int c = 0; c < CountLinesReader(file); c++)
            {
                Table[c] = new Symbol();
            }
        }
        /* CountLinesReader
         * This function uses the string of the file name to count how many lines are in the file to have an accurate count for the array of strings
         * Requires the name of the file to be input so it can count the lines of the correct file
         * this will return lineCounter, an int that stores how many lines are in the file
         */
        public static int CountLinesReader(string file)
        {
            int lineCounter = 0;
            using (var reader = new StreamReader(file))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                }
                return lineCounter;
            }
        }


/*
* Create List ~ This function will create the table using inputs from the user for symbols, R&M Flags, and value
* Will then insert symbols into the array of symbols to later be listed and searched from using the Bianary search tree.
* No inputs, does most of the table creation and finding multiple values
*/
        public void CreateList()
        {
            string file = "Symbols.dat";
            int linecounter = CountLinesReader(file);
                string[] input = null;
                string[] inputs = null;
                string RF = null;
                int val;
            //starts the reading of the file and loops through to make sure no values are missed
            for(int c = 0; c < linecounter; c++)
            {
                input = File.ReadAllLines("symbols.dat");
                string input2 = input[c];      
                inputs = input2.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string test = inputs[1].Substring(0,1);

                char testc = test.ToCharArray()[0];
                int leng = inputs[1].Length;
                //this makes sure all symbols are within the bounds of a valid symbol described by the assignment
                if (leng < 21)
                {
                    if (testc <= 'z' && testc >= 'A')
                    {
                        if (testc == '{' || testc == 92 || testc == '}' || testc == '^' || testc == '_' || testc == '`')
                        {

                        }
                        else
                        {
                            for (int f = 0; f < c; f++)
                            {
                                //this section checks to see if the new symbol is a duplicate of one already in the table then sets the Mflag if it is
                                string testsame = null;
                                if (leng >= 6)
                                {
                                    testsame = inputs[1].Substring(0, 6);
                                }
                                else
                                {
                                    testsame = inputs[1].Substring(0, leng);
                                }

                                if (testsame == Table[f].Sym)
                                {
                                    
                                    Table[f].MF = 1;
                                    /*
                                    Table[c].Sym = "This was a duplicate Symbol";
                                    Table[c].RF = 0;
                                    Table[c].Value = 0;
                                    */
                                }
                                // If the symbol is unique this will throw all aspects into a spot on the table
                                else
                                {
                                    val = Convert.ToInt32(inputs[0]);
                                    Table[c].Value = val;
                                    if (leng >= 6)
                                    {
                                        Table[c].Sym = inputs[1].Substring(0, 6);
                                    }
                                    else
                                    {
                                        Table[c].Sym = inputs[1].Substring(0, leng);
                                    }

                                    RF = inputs[2];
                                    //switch statement for RFlag so it can take in any input of true or false
                                    switch (RF)
                                    {
                                        case "T":
                                            {
                                                Table[c].RF = 1;
                                            }
                                            break;
                                        case "F":
                                            {
                                                Table[c].RF = 0;
                                            }
                                            break;
                                        case "0":
                                            {
                                                Table[c].RF = 0;
                                            }
                                            break;
                                        case "1":
                                            {
                                                Table[c].RF = 1;
                                            }
                                            break;
                                        case "True":
                                            {
                                                Table[c].RF = 1;
                                            }
                                            break;
                                        case "False":
                                            {
                                                Table[c].RF = 0;
                                            }
                                            break;
                                        case "true":
                                            {
                                                Table[c].RF = 1;
                                            }
                                            break;
                                        case "false":
                                            {
                                                Table[c].RF = 0;
                                            }
                                            break;
                                        default:
                                            {
                                                Console.WriteLine("Not Valid\nFLag Set to False");
                                                Table[c].RF = 0;
                                            }
                                            break;

                                    }
                                }
                            }
                        }

                    }
                    else
                    {

                    }
                }

                else
                {

                }

            }
        }

    }
}
