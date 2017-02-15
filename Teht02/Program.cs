using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD levy = new CD { Artist = "FELT", Name = "Flower Flag" };
            
            Biisi biisi1 = new Biisi { Song = "Wind", Length = "02:32" };
            Biisi biisi2 = new Biisi { Song = "Flower Flag", Length = "04:28" };
            Biisi biisi3 = new Biisi { Song = "TRULY GLORY", Length = "05:02" };
            Biisi biisi4 = new Biisi { Song = "Fades Over", Length = "05:09" };
            Biisi biisi5 = new Biisi { Song = "Beautiful Trick", Length = "05:13" };
            Biisi biisi6 = new Biisi { Song = "null", Length = "00;46" };
            Biisi biisi7 = new Biisi { Song = "Flow", Length = "03:04" };
            Biisi biisi8 = new Biisi { Song = "Screen", Length = "03:53" };
            Biisi biisi9 = new Biisi { Song = "Moonlight shines", Length = "04:57" };



            CD songs = new CD();

            // add objects to collection
            songs.AddBiisi(biisi1);
            songs.AddBiisi(biisi2);
            songs.AddBiisi(biisi3);
            songs.AddBiisi(biisi4);
            songs.AddBiisi(biisi5);
            songs.AddBiisi(biisi6);
            songs.AddBiisi(biisi7);
            songs.AddBiisi(biisi8);
            songs.AddBiisi(biisi9);

            songs.PrintData();

            /*
            Biisi biisi5 = songs.GetBiisi(1);
            if (biisi5 != null)
            {
                Console.WriteLine(biisi5.ToString());
            }
            else
            {
                Console.WriteLine("Song not found in that index!");
            }
            */
        }
    }
}
