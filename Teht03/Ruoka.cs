using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Ruoka
    {
        public string Nimi { get; set; }

        public override string ToString()
        {
            return "Nimi: " + Nimi;
        }
    }
}
