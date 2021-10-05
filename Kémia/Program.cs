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
    static List<string> lista = new List<string>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
    }

    private static void OtodikFeladat()
    {
      Console.WriteLine("5. feladat: ");
    }

    private static void NegyedikFeladat()
    {
      int szam = 0;
      foreach (var l in lista)
      {
        
      }
      Console.WriteLine($"4. feladat: Felfedezések száma az ókorban: {}");
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3. feladat: Elemek száma: {lista.Count} ");
    }

    private static void MasodikFeladat()
    {
      StreamReader be = new StreamReader("felfedezesek.csv");
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        lista.Add( int.Parse(a[0], a[1], a[2], a[3], a[4]));
      }
      be.Close();
    }
  }
}
