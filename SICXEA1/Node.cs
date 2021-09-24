using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICXEA1
{
    public class Node
    {
        public string Symbol { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(String V, Node l, Node r)
        {
            Symbol = V;
            left = l;
            right = r;
        }
        public Node(Node search)
        {
            Symbol = search.Symbol;
            left = search.left;
            right = search.right;
        }


    }
}
