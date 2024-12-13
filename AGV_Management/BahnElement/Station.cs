

public class Station : BahnElement
{


  public Station(uint ausrichtung) : base(ausrichtung)
  {
    this.setVerbindung(this.getAusrichtung() % 4, true);
  }
}