using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Kaappi
    {
        public int Taso { get; set; }
        public bool Valo { get; set; }

        private List<Ruoka> kaappi;

        public Kaappi()
        {
            kaappi = new List<Ruoka>();
        }

        public void AddRuoka(Ruoka ruoka)
        {
            kaappi.Add(ruoka);
        }

        public void RemoveRuoka(Ruoka ruoka)
        {
            kaappi.Remove(ruoka);
        }
    }
}
