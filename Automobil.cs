using Lekce10RegistrVozidel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Automobil : Vozidlo
{
    private readonly int pocetKol;
    public int pocetDveri;
    public string model;


    public Automobil(string znackaVozidla, string model, int rokVyroby, string barva, int pocetDveri, int stavTachometru) 
        : base(znackaVozidla, rokVyroby, barva, stavTachometru)
    {
        this.pocetDveri = pocetDveri;
        this.model = model;
        pocetKol=4; 
    }
        public override void VypisVozidlo()
        {
            base.VypisVozidlo();
        }
    }


