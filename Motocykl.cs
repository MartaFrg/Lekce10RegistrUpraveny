using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lekce10RegistrVozidel
{
    internal class Motocykl : Vozidlo
    {
        readonly int pocetKol;
        public string typMotocyklu;
        public Motocykl(string znackaVozidla, string typMotocyklu, int rokVyroby, string barva, int stavTachometru) 
            : base(znackaVozidla, rokVyroby, barva, stavTachometru)
        {
            this.typMotocyklu = typMotocyklu;
            pocetKol = 2;
        }
    }
}
