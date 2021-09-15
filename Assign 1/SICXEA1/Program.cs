using System;

namespace SICXEA1
{
    class Program
    {
        static void Main()
        {
            
            
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
            
                
            
            
        }
    }
}
