using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce10RegistrVozidel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpravceVozidel vozovyPark1 = new SpravceVozidel();
            int volba = 0;
            vozovyPark1.PridejAuto("Škoda", "Octavia", 1990, "modrá", 5, 1800);
            vozovyPark1.PridejMoto("Jawa", "250", 1982, "bílá", 50000);

            while (volba != 4)
            {
                Console.WriteLine("Vyber z možností:" +
                    "\t1. přidej automobil\n" +
                    "\t\t\t2. přidej motocykl\n" +
                    "\t\t\t3. vypiš všechna vozidla\n" +
                    "\t\t\t4. vydat se na cestu\n" +
                    "\t\t\t5. smaž vozidlo\n" +
                    "\t\t\t6. UKONČIT");
                while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 6) Console.WriteLine("Zadej možnost 1-6: ");
                switch (volba)
                {
                    case 1:
                        vozovyPark1.PridejAuto();
                        break;
                    case 2:
                        Console.WriteLine();
                        vozovyPark1.PridejMoto();
                        break;
                    case 3:
                        vozovyPark1.VypisVozidla();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    case 5:
                        //vozovyPark1.SmazVozidlo();
                        break;
                    case 6:
                        Console.WriteLine();
                        break;

                }
                if (volba == 1 || volba == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("pridano vozidlo " + vozovyPark1.seznamVozidel.Last().GetType().Name);
                    Console.WriteLine("celkem vozidel " + vozovyPark1.seznamVozidel.Count);
                    Console.WriteLine("");
                }
            }
        }
    }
}

