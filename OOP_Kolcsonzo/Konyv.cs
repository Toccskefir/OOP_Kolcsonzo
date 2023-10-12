using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kolcsonzo
{
    internal class Konyv : IKolcsonozheto
    {
        private string cim;
        private string szerzo;
        private string isbn;

        public Konyv(string cim, string szerzo, string isbn)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.isbn = isbn;
        }

        public string megjelenitendoNev()
        {
            return $"{this.szerzo} - {this.cim}";
        }
        public int meddigKolcsonozheto()
        {
            return 14;
        }
        public string Cim { get => cim; set => cim = value; }
        public string Szerzo { get => szerzo; set => szerzo = value; }
        public string Isbn { get => isbn; set => isbn = value; }

        public override string ToString()
        {
            return $"{this.megjelenitendoNev()} Kölcsönzési hossz napokban: {this.meddigKolcsonozheto()}";
        }
    }
}
