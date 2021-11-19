using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplex_Beadando
{
    class Kutya
    {
        public int M { get; set; }
        public Kategoria[] Pontszamok { get; set; }

        public Kutya(string sor, int m, int[] Min, int[] Max)
        {
            M = m;
            Pontszamok = new Kategoria[m];
            string[] tomb = sor.Split(' ');
            for (int i = 0; i < m; i++)
                Pontszamok[i] = new Kategoria(int.Parse(tomb[i]), Min[i], Max[i]);
        }
        public bool Kiesett_e(int[] Min)
        {
            for (int i = 0; i < M; i++)
                if (!Pontszamok[i].Valid())
                    return true;
            return false;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < M; i++)
                sum += Pontszamok[i].P;
            return sum;
        }
    }
}
