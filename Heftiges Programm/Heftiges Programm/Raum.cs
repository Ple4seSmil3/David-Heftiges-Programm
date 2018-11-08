using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heftiges_Programm
{
    public class Raum
    {
        private string boden;
        private string wand;
        private string einsatzzweck;
        private int raumNummer;
        private int etage;
        private int temperatur;
        private int luftfeuchte;

        public Raum(int raumNummer, int etage, string einsatzzweck)
        {
            this.raumNummer = raumNummer;
            this.etage = etage;
            this.einsatzzweck = einsatzzweck;
            temperatur = 20;
            luftfeuchte = 20;
        }

        public void Temperatur_einstellen(int temperatur)
        {
            this.temperatur = temperatur;
        }

        public int Luftfeuchte_messen()
        {
            return(luftfeuchte);
        }
    }
}