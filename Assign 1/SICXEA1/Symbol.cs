﻿/* Nathan Aamodt
 * Systems Programming
 * Assign 1
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
    public class Symbol
    {
        public string Sym { get; set; }
        public int RF { get; set; }
        public int Value { get; set; }
        public int MF { get; set; }

        public Symbol(string S = "", int R = 0, int M = 0, int F =0)
        {
            Sym = S;
            RF = R;
            Value = M;
            MF = F;
        }
        public Symbol(Symbol Soul)
        {
            Sym = Soul.Sym;
            RF = Soul.RF;
            Value = Soul.Value;
            MF = Soul.MF;
        }
    }
}
