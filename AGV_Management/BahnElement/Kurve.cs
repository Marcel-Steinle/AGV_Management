

public abstract class Kurve : BahnElement
{


  public Kurve(uint ausrichtung) : base(ausrichtung)
  {
    this.setHatVerbindung(this.getAusrichtung() % 4, true);
    this.setHatVerbindung(this.getAusrichtung() - 1 % 4, true);
  }
}