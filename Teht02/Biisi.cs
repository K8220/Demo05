using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Biisi
    {
        public string Song { get; set; }
        public string Length { get; set; }

        public override string ToString()
        {
            return "   - " + Song + " | " + Length;
        }
    }
}
