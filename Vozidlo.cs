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
        private readonly int rokVyroby;
        private string barva;
        public readonly string znackaVozidla;
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
        public virtual string VypisVozidlo()
        {
            string stav;
            switch (_technicky_stav)
            {
                case 1:
                    stav="dobrý.";
                    break;
                case 2:
                    stav = "špatný.";
                    break;
                case 3:
                    stav = "určený k opravě.";
                    break;

                default: 
                    stav = "není znám.";
                    break;
            }
            return  $"barva: {barva} " +
                    $"\nStáří vozidla: {StariVozidla} roků, najeté kilometry: {StavTachometru}" +
                    $"\nTechnický stav vozidla je {stav}.";
        }
        public void JizdaVozidlem(int delka) {
            if (_technicky_stav < 3)
            {
            _stavTachometru += delka;
            _technicky_stav++;
            }
            else Console.WriteLine("Vybraný vůz je třeba opravit.");
        }
        public void OpravVozidlo()
        {
            _technicky_stav = 1;
        }
    }
}
