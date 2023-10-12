using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kolcsonzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1 = new Konyv("A Gyűrűk Ura", "J.R.R. Tolkien", "9555213655879");
            Dvd dvd1 = new Dvd("Star Wars V. rész - A Birodalom visszavág", 124);
            Dvd dvd2 = new Dvd("Star Wars IV. rész – Egy új remény", 121);
            Dvd dvd3 = new Dvd("Star Wars III. rész – A sithek bosszúja", 140);
            Dvd dvd4 = new Dvd("Indiana Jones és az utolsó kereszteslovag", 127);
            Dvd dvd5 = new Dvd("Az elveszett frigyláda fosztogatói", 115);
            Ujsag ujsag1 = new Ujsag("Képes Sport", 2007, 23);
            Katalogus katalogus1 = new Katalogus();

            katalogus1.AddToList(konyv1);
            katalogus1.AddToList(dvd1);
            katalogus1.AddToList(ujsag1);

            Console.WriteLine(katalogus1);

            //DVD lista
            List<Dvd> dvdList = new List<Dvd>();
            dvdList.Add(dvd1);
            dvdList.Add(dvd2);
            dvdList.Add(dvd3);
            dvdList.Add(dvd4);
            dvdList.Add(dvd5);

            dvdList.Sort();
            foreach (Dvd item in dvdList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
