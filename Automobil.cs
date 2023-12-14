using Lekce10RegistrVozidel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Automobil : Vozidlo
{
    private const int pocetKol=4;
    private readonly int pocetDveri;
    private readonly string model;


    public Automobil(string znackaVozidla, string model, int rokVyroby, string barva, int pocetDveri, int stavTachometru) 
        : base(znackaVozidla, rokVyroby, barva, stavTachometru)
    {
        this.pocetDveri = pocetDveri;
        this.model = model;
    }
        public override string VypisVozidlo() {
        return $"{GetType().Name} {znackaVozidla} {model}, má {pocetKol} kola, je {pocetDveri}-dvéřové, {base.VypisVozidlo()}";
    }
}


