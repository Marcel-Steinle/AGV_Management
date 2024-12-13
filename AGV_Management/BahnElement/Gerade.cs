

public class Gerade : BahnElement
{


  public Gerade(uint ausrichtung) : base(ausrichtung)
  {
    if(ausrichtung >= 2) this.setAusrichtung(0);
    this.setVerbindung(this.getAusrichtung() % 4, true);
    this.setVerbindung(this.getAusrichtung() - 2 % 4, true);
  }
}