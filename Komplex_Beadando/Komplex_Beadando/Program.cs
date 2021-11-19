using System;

namespace Komplex_Beadando
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI.Udvozles();
            Console.ReadLine();
            GUI.Elvalasztas();
            GUI.Kiir("FONTOS! Ha több adatot kér a program, akkor azokat az adatokat szóközzel elválasztva kell megadni!");
            int N = int.Parse(GUI.Beker("Kérem adja meg a versenyző kutyák számát: "));
            int M = int.Parse(GUI.Beker("Kérem adja meg a szempontok számát: "));
            GUI.Elvalasztas();
            Adatok adatok = new Adatok(N, M);
            if (adatok.Eldontes())
                Console.WriteLine("VAN");
            else
                Console.WriteLine("NINCS");
        }
    }
}
