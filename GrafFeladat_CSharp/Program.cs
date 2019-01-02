using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1, 5);
            graf.Hozzaad(1, 2, 9);
            graf.Hozzaad(0, 2, 7);
            graf.Hozzaad(2, 3, 3);
            graf.Hozzaad(3, 4, 11);
            graf.Hozzaad(4, 5, 8);
            graf.Hozzaad(2, 4, 17);

            Console.WriteLine(graf);
            
            graf.MelysegiBejaras(3);
            Console.WriteLine();
            graf.SzellessegiBejar(3);
            Console.WriteLine();

            //Legrövidebb út
            var sulyok = new Dictionary<int, CsucsAdat>(graf.Dijkstra(2));
            foreach(var i in sulyok)
            {
                Console.WriteLine(i.Key+". csúcsba eljutni ->"+i.Value.koltseg);
            }

            Console.ReadLine();
        }
    }
}
