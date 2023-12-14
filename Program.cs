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

            while (volba != 7)
            {
                Console.WriteLine("Vyber z možností:" +
                    "\t1. přidej automobil\n" +
                    "\t\t\t2. přidej motocykl\n" +
                    "\t\t\t3. vypiš všechna vozidla\n" +
                    "\t\t\t4. vydat se na cestu\n" +
                    "\t\t\t5. oprav vozidlo\n" +
                    "\t\t\t6. smaž vozidlo\n" +
                    "\t\t\t7. UKONČIT");
                while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 7) Console.WriteLine("Zadej možnost 1-7: ");
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
                        vozovyPark1.VypisVsechVozidel();
                        break;
                    case 4:
                        if (vozovyPark1.PocetVozidel > 0)
                        {
                            Console.Write($"Zadej číslo vozidla (1-{vozovyPark1.PocetVozidel}) se kterým pojedeš, anebo zadej nulu pro výpis vozidel: ");
                            Vozidlo v = vozovyPark1.VyberVozidlo();
                            if (v.TechnickyStav < 3)
                            {
                                Console.Write($"Zadej délku jízdy v kilometrech: ");
                                int delka;
                                while (!int.TryParse(Console.ReadLine(), out delka) || delka < 1) Console.WriteLine("Zadej vzdálenost: ");
                                Console.WriteLine($"Jedu s vozidelem {v.znackaVozidla} {delka} kilometrů.");
                                v.JizdaVozidlem(delka);
                            }
                            else Console.WriteLine("Vozidlo je třeba opravit.");
                        }
                        else { Console.WriteLine("Seznam neobsahuje žádná vozidla."); }
                        Console.WriteLine("");
                        break;
                    case 5:
                        if (vozovyPark1.PocetVozidel > 0)
                        {
                            Console.WriteLine($"Zadej číslo vozidla, které chceš opravit (1-{vozovyPark1.PocetVozidel}), nebo zadej nulu pro výpis vozidel.");
                            Vozidlo v = vozovyPark1.VyberVozidlo();
                            Console.WriteLine($"Opravuji vozidlo {v.znackaVozidla}.");
                            v.OpravVozidlo();
                        }
                        else { Console.WriteLine("Seznam neobsahuje žádná vozidla."); }
                        Console.WriteLine("");
                        break;
                    case 6:
                        if (vozovyPark1.PocetVozidel > 0)
                        {
                            Console.WriteLine($"Zadej číslo vozidla, které chceš vymazat (1-{vozovyPark1.PocetVozidel}), nebo zadej nulu pro výpis vozidel.");
                            Vozidlo v = vozovyPark1.VyberVozidlo();
                            Console.WriteLine($"Mažu vozidlo {v.znackaVozidla}.");
                            vozovyPark1.VymazVozidlo(v);
                        }
                        else { Console.WriteLine("Seznam neobsahuje žádná vozidla."); }
                        Console.WriteLine("");
                        break;
                    case 7:
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

