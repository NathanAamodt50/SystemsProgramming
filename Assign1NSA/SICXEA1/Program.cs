/* Nathan Aamodt
 * Systems Programming
 * Assign 1
 * Hamer
 * This program will take symbol inputs from symbol.dat create a table using thoes inputs.
 * Then it will search from Test.txt to search for symbols in the table.
 */
using System;

namespace SICXEA1
{
    class Program
    {
        /*Main
         * This function will create the list/table,
         * Call in the search method to search,
         * and call in the view method to list the table.
         */
        static void Main()
        {

            //Calls in the list as well as the functions needed
            List L = new List();
            View.ViewSym(L);
            //List.sortlist(L);
            List.Search(L);

                
            
            
        }
    }
}

