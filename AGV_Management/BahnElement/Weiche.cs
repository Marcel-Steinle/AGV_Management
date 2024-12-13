

public abstract class Weiche : BahnElement
{


  public Weiche(uint ausrichtung) : base(ausrichtung)
  {
    this.setHatVerbindung(this.getAusrichtung() % 4, true);
    this.setHatVerbindung(this.getAusrichtung() - 1 % 4, true);
    this.setHatVerbindung(this.getAusrichtung() - 2 % 4, true);
  }
}