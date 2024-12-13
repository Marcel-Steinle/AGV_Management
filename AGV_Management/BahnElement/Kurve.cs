

public class Kurve : BahnElement
{


  public Kurve(uint ausrichtung) : base(ausrichtung)
  {
    this.setVerbindung(this.getAusrichtung() % 4, true);
    this.setVerbindung( (this.getAusrichtung() + 3 ) % 4, true);
  }
}