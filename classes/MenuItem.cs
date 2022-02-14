using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier2022.classes
{
    class MenuItem
    {
        public string Item { get; set; }
        public char Cle { get; set; }
        public Func<int> Action { get; set; }

        public MenuItem(string i, char c, Func<int> aExecuter)
        {
            Item = i;
            Cle = c;
            Action = aExecuter;
        }

    }
}
