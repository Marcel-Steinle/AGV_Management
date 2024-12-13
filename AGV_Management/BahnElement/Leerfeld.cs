

public abstract class Leerfeld : BahnElement
{


  public Leerfeld(uint ausrichtung) : base(ausrichtung)
  {
    this.setAusrichtung(0);
  }
}