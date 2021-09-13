using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICXEA1
{
    public class List
    {
        public Symbol[] Table;
        public List(int length)
        {
           
            Table = new Symbol[length];
            InitializeTable();
            CreateList();
        }
        public List(Symbol[] Soul)
        {
            Table = Soul;
        }

        public void InitializeTable()
        {
            for(int c = 0; c < Table.Length; c++)
            {
                Table[c] = new Symbol();
            }
        }
        /*
         * Create List ~ This function will create the table using inputs from the user for symbols, R&M Flags.
         * Will then insert symbols into the array of symbols to later be listed and searched from using the Bianary search tree.
         */
        public void CreateList()
        {
            int Val = 0;
            string Rflag = null, Mflag = null, SVal = null;
            do
            {
                for (int f = 0; f < 101; f++)
                {
                    Console.WriteLine("Please Enter a Symbol with a max of 23 characters.");
                    Table[f].Sym = Console.ReadLine();

                    Console.WriteLine("Please enter the RFlag.");
                    Rflag = Console.ReadLine();
                    switch(Rflag)
                    {
                        case "T":
                            {
                                Table[f].RF = 1;
                            }
                            break;
                        case "F":
                            {
                                Table[f].RF = 0;
                            }
                            break;
                        case "0":
                            {
                                Table[f].RF = 0;
                            }
                            break;
                        case "1":
                            {
                                Table[f].RF = 1;
                            }
                            break;
                        case "True":
                            {
                                Table[f].RF = 1;
                            }
                            break;
                        case "False":
                            {
                                Table[f].RF = 0;
                            }
                            break;
                    }
                    Console.WriteLine("Please enter the MFlag.");
                    Mflag = Console.ReadLine();
                    switch (Mflag)
                    {
                        case "T":
                            {
                                Table[f].MF = 1;
                            }
                            break;
                        case "F":
                            {
                                Table[f].MF = 0;
                            }
                            break;
                        case "0":
                            {
                                Table[f].MF = 0;
                            }
                            break;
                        case "1":
                            {
                                Table[f].MF = 1;
                            }
                            break;
                        case "True":
                            {
                                Table[f].MF = 1;
                            }
                            break;
                        case "False":
                            {
                                Table[f].MF = 0;
                            }
                            break;
                    }

                    Console.WriteLine("Would you like to enter anouther symbol?\n Y = Yes\tN = No");
                    SVal = Console.ReadLine();
                    switch(SVal)
                    {
                        case "Y":
                            {
                                Val = 0;
                            }
                            break;
                        case "N":
                            {
                                Val = 1;
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Not Found");
                            }
                            break;
                    }
                }
            }while (Val != 1); 
        }
    }
}
