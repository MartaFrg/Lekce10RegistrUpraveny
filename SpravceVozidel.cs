using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce10RegistrVozidel
{
    public class SpravceVozidel
    {
        private List<Vozidlo> seznamVozidel = new List<Vozidlo>();
        public int PocetVozidel { 
            get {return seznamVozidel.Count;}
        }
        public Vozidlo PodejVozidlo(int poradi)
        {
            return seznamVozidel[poradi];
        }
        public void PridejAuto()
        {
            seznamVozidel.Add(new Automobil(ZnackaVozidla(), ModelAuta(), RokVyroby(), Barva(), PocetDveri(), StavTachometru()));
        }
        public void PridejAuto(string znackaVozidla, string model, int rokVyroby, string barva, int pocetDveri, int stavTachometru)
        {
            seznamVozidel.Add(new Automobil(znackaVozidla, model, rokVyroby, barva, pocetDveri, stavTachometru));
        }
        public void PridejMoto()
        {
            this.seznamVozidel.Add(new Motocykl(ZnackaVozidla(), TypMotocyklu(), RokVyroby(), Barva(), StavTachometru()));
        }
        public void PridejMoto(string znackaVozidla, string typMotocyklu, int rokVyroby, string barva, int stavTachometru)
        {
            this.seznamVozidel.Add(new Motocykl(znackaVozidla, typMotocyklu, rokVyroby, barva, stavTachometru));
        }
        public void VymazVozidlo(int poradi)
        {
            seznamVozidel.RemoveAt(poradi);
        }
        int RokVyroby()
        {
            int rokVyroby;
            Console.Write("Zadej rok výroby vozidla: ");
            while (!int.TryParse(Console.ReadLine(), out rokVyroby) || rokVyroby < 1900 || rokVyroby > 2023) Console.Write("Zadej rok výroby vozidla: ");
            return rokVyroby;
        }
        string Barva()
        {
            Console.Write("Zadej barvu vozidla: ");
            return Console.ReadLine();
        }
        string ZnackaVozidla()
        {
            Console.Write("Zadej značku vozidla: ");
            return Console.ReadLine();
        }
        int StavTachometru()
        {
            int stav;
            Console.Write("Zadej počáteční stav tachometru: ");
            while (!int.TryParse(Console.ReadLine(), out stav) || stav < 0) Console.Write("Zadej stav tachometru: ");
            return stav;
        }
        int PocetDveri()
        {
            int pocet;
            Console.Write("Zadej počet dveří automobilu: ");
            while (!int.TryParse(Console.ReadLine(), out pocet) || pocet < 2|| pocet > 7) Console.Write("Zadej počet dveří: ");
            return pocet;
        }
        string TypMotocyklu()
        {
            Console.Write("Zadej typ motorky: ");
            return Console.ReadLine();
        }
        string ModelAuta()
        {
            Console.Write("Zadej název modelu automobilu: ");
            return Console.ReadLine();
        }
        public void VypisVozidla()
        {
            int poradi=1;        
            foreach (var v in seznamVozidel)
            {
                Console.Write($"{poradi}. {v.GetType().Name} {v.znackaVozidla} ");
                if (v is Automobil automobil) Console.Write(automobil.model);
                if (v is Motocykl motocykl) Console.Write(motocykl.typMotocyklu);
                Console.WriteLine($", barva: {v.barva} ");
                Console.WriteLine($"Rok výroby: {v.rokVyroby}, najeté kilometry: {v.StavTachometru}");
                Console.WriteLine($"Technický stav vozidla je {v.TechnickyStav}.");
                Console.WriteLine("");
                poradi++;
            }
        }



    }
}
