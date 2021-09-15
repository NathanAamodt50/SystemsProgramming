﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SICXEA1
{
    public class BST
    {
       
        public static void Search(List L)
        {
            string searchp = null;
            string searchpsub = null;
            using (StreamReader sr = File.OpenText("Test.txt"))
            {
                                
                while((searchp = sr.ReadLine()) != null)
                {
                    searchpsub = searchp.Substring(0, 6);

                    for(int c = 0; c < 1; c++)
                    {
                        if(L.Table[c].Sym == searchpsub)
                        {
                            Console.WriteLine("Symbol Found:" +L.Table[c].Value +"\t" + L.Table[c].Sym + "\t" + L.Table[c].RF + "\t"+L.Table[c].MF);
                        }
                        else
                        {
                            Console.WriteLine("Symbol Not Found: " + searchpsub);
                        }
                    }
                }
            }
        }
    }
}
