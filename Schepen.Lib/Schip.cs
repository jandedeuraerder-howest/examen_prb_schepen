using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schepen.Lib
{
    public class Schip
    {
        private string naam;
        private string scheepstype;
        private int bemanning;
        private byte snelheid;

        public string Naam
        {
            get { return naam; }
            set 
            {
                value = value.Trim();
                if (value == "")
                    throw new Exception("Naam kan niet leeg zijn!");
                naam = value; 
            }
        }

        public string Scheepstype
        {
            get { return scheepstype; }
            set
            {
                value = value.Trim();
                if (value == "")
                    throw new Exception("Scheepstype kan niet leeg zijn!");
                scheepstype = value; 
            }
        }


        public int Bemanning
        {
            get { return bemanning; }
            set 
            {
                if (value < 1)
                    throw new Exception("Aantal bemanningsleden minimaal 1");
                bemanning = value; 
            }
        }

        public byte Snelheid
        {
            get { return snelheid; }
            set 
            {
                if (value < 0)
                    throw new Exception("Snelheid moet groter zijn dan 0");
                snelheid = value; 
            }
        }
        public Schip(string naam, string scheepstype, int bemanning, byte snelheid)
        {
            Naam = naam;
            Scheepstype = scheepstype;
            Bemanning = bemanning;
            Snelheid = snelheid;
        }
        public override string ToString()
        {
            return naam + " - " + scheepstype;
        }





    }
}
