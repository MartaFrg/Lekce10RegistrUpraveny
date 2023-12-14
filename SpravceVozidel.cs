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
        public void VymazVozidlo(Vozidlo v)
        {
            seznamVozidel.Remove(v);
        }
        public Vozidlo VyberVozidlo()
        {
            int cisloVozu=0;
            while (cisloVozu == 0)
            {
                while (!int.TryParse(Console.ReadLine(), out cisloVozu) || cisloVozu < 0 || cisloVozu > seznamVozidel.Count) Console.WriteLine($"Zadej možnost 1-{seznamVozidel.Count}: ");
                if (cisloVozu == 0) { VypisVsechVozidel(); Console.Write("Zadej číslo vozidla: "); };
            }
            return seznamVozidel[cisloVozu-1];
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
        public void VypisVsechVozidel()
        {
            int poradi=1;        
            foreach (var v in seznamVozidel)
            {
                Console.Write(poradi+". ");
                Console.WriteLine(  v.VypisVozidlo());
                Console.WriteLine("");
                poradi++;
            }
            if (seznamVozidel.Count == 0) {Console.WriteLine("Není uloženo žádné vozidlo.\n"); }
        }



    }
}
