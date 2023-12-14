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

            while (volba != 6)
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
                        Console.WriteLine("");
                        Console.WriteLine("Přidán automobil.");
                        break;
                    case 2:
                        Console.WriteLine();
                        vozovyPark1.PridejMoto();
                        Console.WriteLine("");
                        Console.WriteLine("Přidán motocykl.");
                        break;
                    case 3:
                        vozovyPark1.VypisVozidla();
                        break;
                    case 4:
                        Console.WriteLine($"Zadej číslo vozidla, se kterým chceš jet (1-{vozovyPark1.PocetVozidel}), nebo zadej nulu pro výpis vozidel.");
                        //ZjistitVozidlo().JizdaVozidlem(200);
                        break;
                    case 5:
                        int cisloVozu;
                        Console.WriteLine($"Zadej číslo vozidla, které chceš vymazat (1-{vozovyPark1.PocetVozidel}), nebo zadej nulu pro výpis vozidel.");
                        while (!int.TryParse(Console.ReadLine(), out cisloVozu) || cisloVozu < 0 || cisloVozu > vozovyPark1.PocetVozidel) Console.WriteLine("Zadej možnost 1-6: ");
                        //if (cisloVozu == 0)
                        vozovyPark1.VymazVozidlo(0);
                        break;
                    case 6:
                        Console.WriteLine();
                        break;

                }
                if (volba == 1 || volba == 2)
                {
                    Console.WriteLine("celkem vozidel " + vozovyPark1.PocetVozidel);
                    Console.WriteLine("");
                }
            }
        }
    }
}

