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

namespace SICXEA1
{
    public static class View
    {
        /*
         * ViewSym
         * This function takes the table and prints it out in groups of 5
         * This requires the List to be input so it has something to print
         */
        public static void ViewSym(List L)
        {
            Console.WriteLine("Symbol\t\tRFlag\tMflag\tValue");
            for (int i = 0; i < L.Table.Length; i++)
            {
                if (i == 5 || i == 10 || i == 15 || i == 20 || i == 25 || i ==30)
                {
                    Console.WriteLine("Press a key to continue!");
                    Console.ReadKey(true);
                    Console.WriteLine(L.Table[i].Sym + "  \t " + L.Table[i].RF +"\t" + L.Table[i].MF+ "  \t   " + L.Table[i].Value);
                }
                else
                {
                    Console.WriteLine(L.Table[i].Sym + "  \t " + L.Table[i].RF + "\t" + L.Table[i].MF + "  \t  " + L.Table[i].Value);
                }
            }


            return;
        }
    }
}
