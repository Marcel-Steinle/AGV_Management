

using System.ComponentModel.DataAnnotations;
using System.Dynamic;

public abstract class BahnElement
{

  private uint ausrichtung;
  private bool[] hatVerbindung;


  public BahnElement(uint ausrichtung)
  {
    this.hatVerbindung = new bool[4];
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


  public void setHatVerbindung(uint index, bool verbindung)
  {
    this.hatVerbindung[index] = verbindung;
  }

  public bool getHatVerbindung(uint index)
  {
    return this.hatVerbindung[index];
  }

  public void setAusrichtung(uint ausri)
  {
    this.ausrichtung = Math.Max(0, Math.Min(3, ausri));
  }

  public uint getAusrichtung()
  {
    return this.ausrichtung;
  }
}