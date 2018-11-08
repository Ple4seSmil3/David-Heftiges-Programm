using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heftiges_Programm
{
    public class Bauelement
    {
        public string form;
        public string farbe;
        public string material;
        public int größe;
        public int position;

        public Bauelement(string form, string farbe, string material, int größe, int position)
        {
            this.form = form;
            this.farbe = farbe;
            this.material = material;
            this.größe = größe;
            this.position = position;

        }


        #region get_setter

        public string _farbe
        {
            get { return(farbe); }
            set
            {
                farbe = value;
            }
        }

        public string _form
        {
            get { return (form); }
        }


        public int _größe
        {
        get { return (größe); }
        }


        public int _position
        {
            get { return (position); }
        }


        public string _material
        {
            get { return (material); }
        }

        #endregion

    }
}