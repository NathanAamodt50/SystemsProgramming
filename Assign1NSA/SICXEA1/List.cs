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
        public  Symbol[] Table;
        public  string[] data;
        public  int length = 0;
        //List() defines the table as well as calls in the functions we need to complete the table.
        // no inputs
        // no outputs
        public List()
        {
            string file = "Symbols.dat";
            Table = new Symbol[CountLinesReader(file)];
            InitializeTable(file);
            CreateList();
           // gettestdata();
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
                length++;
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

                                string testsame = null;
                                if (leng >= 6)
                                {
                                    testsame = inputs[1].Substring(0, 6);
                                }
                                else
                                {
                                    testsame = inputs[1].Substring(0, leng);
                                }
                                //this section checks to see if the new symbol is a duplicate of one already in the table then sets the Mflag if it is
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
                        length--;
                    }
                }

                else
                {

                }
               
            }
        }
        /* Sortlist
         * Inputs:None
         * Outputs:None
         * This function will sort the table into alphabetical order to be compared agaist Test.dat
         */

        /*
        public static void sortlist(List L)
        {
            for(int c = 0; c < L.length; c++)
            {
                string first;
                string second;
                string[] sfirst = null;
                string[] ssecond = null;

                sfirst[0] = L.Table[c].Sym;
                ssecond[0] = L.Table[(c + 1)].Sym;
                Console.WriteLine(sfirst);
                first = sfirst[0].Substring(0);
                second = ssecond[0].Substring(0);
                Console.WriteLine(first);
                first = first.ToUpper();
                second = second.ToUpper();
                Console.WriteLine(first);
                int one = int.Parse(first);
                int two = int.Parse(second);

                while (one > two)
               {
                    string str = L.Table[c].Sym;
                    int I = L.Table[c].Value;
                    int R = L.Table[c].RF;
                    int M = L.Table[c].MF;

                    L.Table[c].Sym = L.Table[c + 1].Sym;
                    L.Table[c].Value = L.Table[c + 1].Value;
                    L.Table[c].RF = L.Table[c + 1].RF;
                    L.Table[c].MF = L.Table[c + 1].MF;

                    L.Table[c + 1].Sym = str;
                    L.Table[c + 1].Value = I;
                    L.Table[c + 1].MF = M;
                    L.Table[c + 1].RF = R;
                }
            }
        }
        */
        /* Get test data
         * Inputs: None
         * Outputs: None
         * This function will fill the array of strings "data" with all the symbols to look up from Test.dat
         */

        /*
        public void gettestdata()
        {

            data = File.ReadAllLines("Test.dat");
            Array.Sort(data, StringComparer.InvariantCulture);

        }
        */

        /* Bianary Search Tree
         * Inputs: List L
         * Outputs: None
         * This function Will search the sorted lists data and table then start in the middle of table to search for a matching symbol
         */

        /*
        public static void Search(List L)
        {
            Console.WriteLine("Symbol Lookup:\tValue\tSymbol\tRF\tMF");
            int first = 0;
            int last = L.length;
            bool found = false;
            for(int c =0;c<CountLinesReader("Test.dat");c++)
            {
                int Trav = 0;
                while (found != true && first <= last)
                {
                    int middle = (first + last) / 2;
                    Console.WriteLine(middle);

                    string tablem = L.Table[middle].Sym;
                    string datam = L.data[c];

                    string tabled = tablem.Substring(0,1);
                    string datad = datam.Substring(0,1);

                    tabled = tabled.ToUpper();
                    datad = datad.ToUpper();

                    char tablec = tabled.ToCharArray()[0];
                    char datac = datad.ToCharArray()[0];

                    

                    int tablei = Convert.ToInt32(tablec);
                    int datai = Convert.ToInt32(datac);

                    if (L.Table[middle].Sym == L.data[c])
                    {
                    found = true;
                    Trav++;
                        Console.WriteLine("Symbol Found: " + L.Table[middle].Value + "\t" + L.Table[middle].Sym + "\t" + L.Table[middle].RF + "\t" + L.Table[middle].MF
                            + "\nSearches done for Symbol:"+ Trav);
                    }
                     else if (tablei > datai)
                     {
                        last = middle;
                        Trav++;
                     }
                     else
                     {
                        first = middle;
                        Trav++;
                     }
                }
            }    
        }    
        */
        
        /*Search~Non-Bianary
         * Inputs the List L
         * Outputs onto the screen
         * This function I threw together to see if the table wasnt being stored propperly a while ago, but can actually search through it easily
         * */
        public static void Search(List L)
        {
            Console.WriteLine("Symbol Lookup:\tValue\tSymbol\tRF\tMF");
            string searchp = null;
            string searchpsub = null;
            using (StreamReader sr = File.OpenText("Test.dat"))
            {

                while ((searchp = sr.ReadLine()) != null)
                {

                    for (int c = 0; c < L.Table.Length; c++)
                    {
                        int leng = searchp.Length;
                        if (leng >= 6)
                        {
                            searchpsub = searchp.Substring(0, 6);
                        }
                        else
                        {
                            searchpsub = searchp.Substring(0, leng);
                        }
                        if (L.Table[c].Sym == searchpsub)
                        {
                            Console.WriteLine("Symbol Found:\t" + L.Table[c].Value + "\t" + L.Table[c].Sym + "\t" + L.Table[c].RF + "\t" + L.Table[c].MF); ;
                        }
                        else
                        {
                            //Console.WriteLine("Symbol Not Found: " + searchpsub);
                        }

                    }
                }
            }
        }
    }
}
