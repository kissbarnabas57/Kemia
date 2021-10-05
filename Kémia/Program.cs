using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kémia
{
  class Program
  {
    static List<Elemek> lista = new List<Elemek>();
        static void Main(string[] args)
    {
            
        MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladat();

      Console.ReadKey();
    }

        private static void NyolcadikFeladat()
        {
            Console.WriteLine("8. feladat: Statisztika ");
        }

        private static void HetedikFeladat()
        {
            Console.WriteLine("7. feladat: {} év volt a leghosszabb időszak két elem felfedezése között. ");  
        }

        private static void HatodikFeladat()
        {
            int i = 0;
            while (i < lista.Length && lista[i]. != vegyjel)
            {
                i++;
            }
            if (i < lista.Length)
            {

            }
            else
            {
                Console.WriteLine("Nincs ilyen elem az adatforrásban.");
            }

            Console.WriteLine("6. feladat: Keresés ");
        }

        private static void OtodikFeladat()
        {
            string vegyjel;
            bool nemjo;
            nemjo = false;

            vegyjel = Console.ReadLine();

            if (vegyjel.Length > 2 | vegyjel == "")
            {
                nemjo = true;
            }

            if (!)
            {
                nemjo = true; ;
            }
        Console.WriteLine("5. feladat: Kérek egy vegyjelet: ");
        }

    private static void NegyedikFeladat()
    {
      int szam = 0;
      foreach (var l in lista)
      {
       if (l.Ev == "Ókor")
       {
        szam++;
       }
      }
      Console.WriteLine($"4. feladat: Felfedezések száma az ókorban: {szam}");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3. feladat: Elemek száma: {lista.Count} ");
    }

    private static void MasodikFeladat()
    {
      StreamReader be = new StreamReader("felfedezesek.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split(';');
                lista.Add(new Elemek(Convert.ToString(a[0]), Convert.ToString(a[1]), Convert.ToString(a[2]), Convert.ToInt32(a[3]), Convert.ToString(a[4])));
            }
      be.Close();
    }
  }
}
