using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kémia
{
  class Elemek
  {
    private string ev;

    public string Ev
    {
      get { return ev; }
      set { ev = value; }
    }
    private string elem;

    public string Elem
    {
      get { return elem; }
      set { elem = value; }
    }
    private string vegyjel;

    public string Vegyjel
    {
      get { return vegyjel; }
      set { vegyjel = value; }
    }
    private int rendszam;

    public int Rendszam
    {
      get { return rendszam; }
      set { rendszam = value; }
    }
    private string felfedezo;

    public string Felfedezo
    {
      get { return felfedezo; }
      set { felfedezo = value; }
    }

    public Elemek(string ev, string elem, string vegyjel, int rendszam, string felfedezo)
    {
      this.ev = ev;
      this.elem = elem;
      this.vegyjel = vegyjel;
      this.rendszam = rendszam;
      this.felfedezo = felfedezo;
    }
  }
}
