using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lekce10RegistrVozidel
{
    public abstract class Vozidlo
    {
        public readonly int rokVyroby;
        public string barva;
        public readonly string znackaVozidla;
        //public readonly int pocetKol;
        private int _stavTachometru;
        private int _technicky_stav = 1;
        public Vozidlo(string znackaVozidla, int rokVyroby, string barva, int stavTachometru)
        {
            this.znackaVozidla = znackaVozidla;
            this.rokVyroby = rokVyroby;
            this.barva = barva;
            _stavTachometru = stavTachometru;
        }
        public int StavTachometru
        {
            get
            {
                return _stavTachometru;
            }
        }
        public int StariVozidla 
        {
            get { return DateTime.Now.Year - rokVyroby; }
        }
        public int TechnickyStav
        {
            get { return _technicky_stav;}
        }
        public virtual void VypisVozidlo()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("Rok výroby: " + rokVyroby);
            Console.WriteLine("Značka vozidla: " + znackaVozidla);
            Console.WriteLine("Technický stav je ");
            switch (_technicky_stav)
            {
                case 1: Console.WriteLine("dobrý.");
                break; 
                case 2: Console.WriteLine("špatný.");
                break; 
                case 3: Console.WriteLine("určený k opravě.");
                break;
            }
        }
        public void JizdaVozidlem(int delka) {
            if (_technicky_stav < 3)
            {
            _stavTachometru += delka;
                _technicky_stav++;
            }
            else Console.WriteLine("Vybraný vůz je třeba opravit.");
        }
    }
}
