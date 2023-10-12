using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kolcsonzo
{
    internal class Katalogus
    {
        private List<IKolcsonozheto> list;

        public Katalogus()
        {
            this.list = new List<IKolcsonozheto>();
        }

        internal List<IKolcsonozheto> List { get => list; set => list = value; }

        public void AddToList(IKolcsonozheto item)
        {
            list.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Katalógus:");
            foreach(IKolcsonozheto item in this.list)
            {
                sb.AppendLine();
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
