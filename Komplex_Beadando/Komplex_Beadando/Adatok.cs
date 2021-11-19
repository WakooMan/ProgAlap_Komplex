using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplex_Beadando
{
    class Adatok
    {
        public int N { get; set; }
        public int M { get; set; }
        public Kutya[] Kutyak { get; set; }
        public List<int> Osszesitett;

        public Adatok(int n, int m)
        {
            N = n;
            M = m;
            string[] t1 = GUI.Beker("Kérem adja meg maximális pontszámokat az egyes szempontok alapján: ").Split(' ');
            string[] t2 = GUI.Beker("Kérem adja meg minimális pontszámokat az egyes szempontok alapján: ").Split(' ');
            GUI.Elvalasztas();
            int[] Min = new int[M];
            int[] Max = new int[M];
            Osszesitett = new List<int>();
            Kutyak = new Kutya[N];
            for (int i = 0; i < M; i++)
            {
                Max[i] = int.Parse(t1[i]);
                Min[i] = int.Parse(t2[i]);
            }
            for (int i = 0; i < N; i++)
            {
                Kutyak[i] = new Kutya(GUI.Beker("Kérem adja meg a(z) " + (i+1) + ". kutya pontszámait az egyes szempontok alapján: "), M, Min, Max);
                if (!Kutyak[i].Kiesett_e(Min))
                    Osszesitett.Add(i);
            }
            GUI.Elvalasztas();
        }
        private int[] KatLegjobbak()
        {
            int[] maxok = new int[M];
            for (int i = 0; i < M; i++)
                maxok[i] = -1;
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    if ((maxok[i] == -1 && Kutyak[j].Pontszamok[i].Valid()) || (maxok[i] != -1 && Kutyak[maxok[i]].Pontszamok[i].P < Kutyak[j].Pontszamok[i].P))
                        maxok[i] = j;
            return maxok;
        }
        
        private int AbsLegjobb()
        {
            int maxidx = Osszesitett[0];
            for (int i = 1; i < Osszesitett.Count; i++)
            {
                if (Kutyak[maxidx].Sum() < Kutyak[Osszesitett[i]].Sum())
                    maxidx = Osszesitett[i];
            }
            return maxidx;
        }

        public bool Eldontes()
        {
            if (Osszesitett.Count > 0)
            {
                int[] maxidxek = KatLegjobbak();
                int absmaxidx = AbsLegjobb();
                for (int i = 0; i < M; i++)
                    if (maxidxek[i] == absmaxidx)
                        return false;
                return true;
            }
            else
                return false;
        }
    }
}
