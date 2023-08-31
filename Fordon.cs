using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KlasserObjekt
{
    public class Fordon
    {
        private string märke;
        private int hästkraft;

        private string modell;

        public Fordon(string m, int hp, string mo) //konstruktor
        {
            märke = m;
            hästkraft = hp;
            modell = mo;
        }

        public string Märke
        {
            get { return märke;}
            set { märke = value; }
        }

        public int Hästkraft
        {
            get { return hästkraft; }
            set { hästkraft = value; }
        }

        public string Modell 
        {
            get { return modell; }
            set {modell = value; }
        }




    }
}