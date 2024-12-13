

using System.ComponentModel.DataAnnotations;
using System.Dynamic;

public abstract class BahnElement
{

  private uint ausrichtung;
  private bool[] verbindung;


  public BahnElement(uint ausrichtung)
  {
    this.verbindung = new bool[4];
    this.ausrichtung = ausrichtung;
    if(this.ausrichtung >= 4) this.ausrichtung = 0;
  }

  public bool istHaltepunkt()
  {
    return (this is Haltepunkt);
  }

  public bool istStation()
  {
    return (this is Station);
  }


  public void setVerbindung(uint index, bool verbindung)
  {
    this.verbindung[index] = verbindung;
  }

  public bool getVerbindung(uint index)
  {
    return this.verbindung[index];
  }

  public void setAusrichtung(uint ausri)
  {
    this.ausrichtung = Math.Max(0, Math.Min(3, ausri));
  }

  public uint getAusrichtung()
  {
    return this.ausrichtung;
  }

  public uint Ausrichtung
  {
    get { return this.ausrichtung; }
    set { this.ausrichtung = Math.Max(0, Math.Min(3, value)); }
  }
}