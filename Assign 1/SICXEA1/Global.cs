using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICXEA1
{
    class Global
    {
        /*public static void Set()
        {
            bool Val = true;
            string Rflag = null, Mflag = null, SVal = null;

            int TableSize;
            Console.WriteLine("How long would of a table would you like to create?\n(Up to 101)");
            TableSize = Int32.Parse(Console.ReadLine());

            //while(Val == true)
            // {
            for (int f = 0; f < TableSize; f++)
            {
                Console.WriteLine("Please Enter a Symbol with a max of 23 characters.");
                Table[f].Sym = Console.ReadLine();

                Console.WriteLine("Please enter the RFlag.");
                Rflag = Console.ReadLine();
                switch (Rflag)
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
                    default:
                        {
                            Console.WriteLine("Not Valid\nFLag Set to False");
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
                    default:
                        {
                            Console.WriteLine("Not Valid\nFLag Set to False");
                        }
                        break;
                }

                /* Console.WriteLine("Would you like to enter anouther symbol?\n Y = Yes\tN = No");
                 SVal = Console.ReadLine();
                 switch(SVal)
                 {
                     case "Y":
                         {
                             Val = true;
                         }
                         break;
                     case "N":
                         {
                             Val = false;
                         }
                         break;
                     default:
                         {
                             Console.WriteLine("Not Found");
                         }
                         break; */
                //}
                // }
            }
        }
