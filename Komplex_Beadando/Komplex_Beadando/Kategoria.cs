using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplex_Beadando
{
    class Kategoria
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int P { get; set; }
        public bool Valid() { return P <= Max && P >= Min; }
        public Kategoria(int p, int min, int max) { P = p; Max = max; Min = min; }
    }
}
