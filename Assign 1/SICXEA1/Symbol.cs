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
        public int MF { get; set; }

        public Symbol(string S = "", int R = 0, int M = 0)
        {
            Sym = S;
            RF = R;
            MF = M;
        }
        public Symbol(Symbol Soul)
        {
            Sym = Soul.Sym;
            RF = Soul.RF;
            MF = Soul.MF;
        }
    }
}
