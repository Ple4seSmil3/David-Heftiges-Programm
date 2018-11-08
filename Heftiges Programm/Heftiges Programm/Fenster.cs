using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heftiges_Programm
{
    public class Fenster : Bauelement
    {
        private string zustand;

        public Fenster(string form, string farbe, string material, int größe, int position, string zustand):base(form, farbe, material, größe, position)
        {
            this.zustand = zustand;
        }

        public void Öffnen()
        {
            zustand = "offen";
        }

        public void Schließen()
        {
            zustand = "geschlossen";
        }
    }
}