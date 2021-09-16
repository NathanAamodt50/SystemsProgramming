/* Nathan Aamodt
 * Systems Programming
 * Assign 1
 * This program will take symbol inputs from symbol.dat create a table using thoes inputs.
 * Then it will search from Test.txt to search for symbols in the table.
 */
using System;

namespace SICXEA1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Blank Lines on Table are invalid Symbol spots!");
            
            List L = new List();


            string choice = null;

            View.ViewSym(L);
            Console.WriteLine("Would you like to search the test file for some Symbols from the table?\n Y=Yes N=No\n");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "Y":
                    BST.Search(L);
                    break;
                case "y":
                    BST.Search(L);
                    break;
                default:
                    Console.WriteLine("ok fine");
                    break;
            }


            Console.WriteLine("Thank you for using my messed up program!");
                
            
            
        }
    }
}
