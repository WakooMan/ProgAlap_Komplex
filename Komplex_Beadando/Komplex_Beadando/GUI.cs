using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Komplex_Beadando
{
    static class GUI
    {
        public static void Udvozles()
        {
            StreamReader reader;
            using (reader = new StreamReader("Udvozles.txt"))
            {
                string sor;
                while ((sor = reader.ReadLine()) != null)
                {
                    Console.WriteLine(sor);
                }
            }
        }
        public static string Beker(string bekeres)
        {
            Console.Write(bekeres);
            string sor = Console.ReadLine();
            return sor;
        }

        public static void Elvalasztas()
        {
            Console.WriteLine("\n-------------------------------\n");
        }

        public static void Kiir(string mit)
        {
            Console.WriteLine(mit);
        }

    }
}
