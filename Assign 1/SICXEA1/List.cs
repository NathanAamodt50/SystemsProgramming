using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SICXEA1
{
    public class List
    {
        public Symbol[] Table;
        public List()
        {
            string file = "Symbols.dat";
            Table = new Symbol[CountLinesReader(file)];
            InitializeTable();
            CreateList();
        }
        public List(Symbol[] Soul)
        {
            Table = Soul;
        }

        public void InitializeTable()
        {
            for (int c = 0; c < Table.Length; c++)
            {
                Table[c] = new Symbol();
            }
        }
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
*/
        public void CreateList()
        {
            string file = "Symbols.dat";
            int linecounter = CountLinesReader(file);
                string[] input = null;
                string[] inputs = null;
                string RF = null;
                int val;
            
            for(int c =0; c < linecounter; c++)
            {
                input = File.ReadAllLines("symbols.dat");
                string input2 = input[c];      
                inputs = input2.Split(' ');

                string test = inputs[c].Substring(0,1);

                char testc = test.ToCharArray()[0];

                if (testc >= 'A' && testc <= 'z')
                {
                    if (testc == '{' || testc == 92 || testc == '}'|| testc == '^'|| testc == '_'|| testc == '`')
                    {
                        Console.WriteLine("Symbol is Invalid, Moving onto Next\n");
                    }
                    else
                    {
                        for (int i = 0; i < linecounter; i++)
                        {
                            val = Convert.ToInt32(inputs[0]);
                            Table[c].Value = val;

                            Table[c].Sym = inputs[1].Substring(0, 6);
                            RF = inputs[2];
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
                                default:
                                    {
                                        Console.WriteLine("Not Valid\nFLag Set to False");
                                    }
                                    break;
                           }
                       }
                        
                   }



                    
                } 
                else
                {
                    Console.WriteLine("Symbol is Invalid, Moving onto Next\n");
                }
           }
        }

    }
}
