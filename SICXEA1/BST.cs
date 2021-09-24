/* Nathan Aamodt
*Systems Programming
* Assign 1
 * Hamer
 * This program will take symbol inputs from symbol.dat create a table using thoes inputs.
 *Then it will search from Test.txt to search for symbols in the table.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SICXEA1
{
    public class BST
    {
        // Search
       //This function was supposed to be a bianary search tree, but after alot of time struggling I used this to make sure I could implement some kind of search method.
       //After a couple days trying to figure it out with no luck this became my main search function
       //Inputs the List class so it can effectivly search through all values in the table
        public static void Search(List L)
        {
            string searchp = null;
            string searchpsub = null;
            using (StreamReader sr = File.OpenText("Test.dat"))
            {
                                
                while((searchp = sr.ReadLine()) != null)
                {
                    searchpsub = searchp.Substring(0, 6);

                    for(int c = 0; c < L.Table.Length; c++)
                    {
                        
                            if (L.Table[c].Sym == searchpsub)
                            {
                                Console.WriteLine("Symbol Found:" + L.Table[c].Value + "\t" + L.Table[c].Sym + "\t" + L.Table[c].RF + "\t" + L.Table[c].MF);
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
