using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lekce10RegistrVozidel
{
    internal class Motocykl : Vozidlo
    {
        private const int pocetKol=2;
        public readonly string typMotocyklu;
        public Motocykl(string znackaVozidla, string typMotocyklu, int rokVyroby, string barva, int stavTachometru) 
            : base(znackaVozidla, rokVyroby, barva, stavTachometru)
        {
            this.typMotocyklu = typMotocyklu;
        }
        public override string VypisVozidlo()
        {
            return $"{ GetType().Name} { znackaVozidla} { typMotocyklu}, má {pocetKol} kola, {base.VypisVozidlo()}";
        }
    }
}
