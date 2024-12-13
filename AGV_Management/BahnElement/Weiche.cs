

public class Weiche : BahnElement
{


  public Weiche(uint ausrichtung) : base(ausrichtung)
  {
    this.setVerbindung(this.getAusrichtung() % 4, true);
    this.setVerbindung( (this.getAusrichtung() - 1 ) % 4, true);
    this.setVerbindung( (this.getAusrichtung() - 2 ) % 4, true);
  }
}