using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kolcsonzo
{
    internal class Dvd : IKolcsonozheto, IComparable<Dvd>
    {
        private string cim;
        private int hossz;      //percekben

        public Dvd(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
        }

        public string Cim { get => cim; set => cim = value; }
        public int Hossz { get => hossz; set => hossz = value; }

        public string megjelenitendoNev()
        {
            return $"{this.cim} ({this.hossz})";
        }

        public int meddigKolcsonozheto()
        {
            return 7;
        }

        public int CompareTo(Dvd other)
        {
            return other.hossz - this.hossz;
        }

        public override string ToString()
        {
            return $"{this.megjelenitendoNev()} Kölcsönzési hossz napokban: {this.meddigKolcsonozheto()}";
        }
    }
}
