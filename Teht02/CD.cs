using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class CD
    {
        public string Name = "Flower Flag";
        public string Artist = "FELT";

        private List<Biisi> cd;

        public CD()
        {
            cd = new List<Biisi>();
        }

        public void AddBiisi(Biisi biisi)
        {
            cd.Add(biisi);
        }

        public void PrintData()
        {
            Console.Write(" CD data:\n - name: " + Name + "\n - artist: " + Artist + "\n - songs:\n");
            foreach (Biisi biisi in cd)
            {
                Console.WriteLine(biisi.ToString());
            }
        }

        public Biisi GetBiisi(int index)
        {
            if (index < cd.Count)
                return cd.ElementAt(index);
            else return null;
        }
    }
}
