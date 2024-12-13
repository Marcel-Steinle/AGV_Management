

using System.Runtime.InteropServices;

public class Landkarte
{

  private BahnElement[,] karte;


  public Landkarte()
  {
    getKarteAusDatei();
  }

  public void getKarteAusDatei(string path="C:\\Users\\DEBLUFLO\\Desktop\\karte.txt")
  {
    string lines = File.ReadAllText(path);
    string[] infos = lines.Split(' ');
    uint breite = Convert.ToUInt32(infos[0]);
    uint hoehe = Convert.ToUInt32(infos[1]);
    this.karte = new BahnElement[breite, hoehe];
    for(int i = 0; i < breite; i++)
    {
      for(int j = 0; j < hoehe; j++)
      {
        char[] zelle = infos[i * breite + j + 2].ToCharArray();
        char bahnTyp = zelle[0];
        uint richtung = Convert.ToUInt32(zelle[1]);
        switch(bahnTyp)
        {
          case 'g':
            karte[i, j] = new Gerade(richtung);
            break;
          case 'h':
            karte[i, j] = new Haltepunkt(richtung);
            break;
          case 'k':
            karte[i, j] = new Kurve(richtung);
            break;
          case 'l':
            karte[i, j] = new Leerfeld(richtung);
            break;
          case 's':
            karte[i, j] = new Station(richtung);
            break;
          case 'w':
            karte[i, j] = new Weiche(richtung);
            break;
        }
      }
    }
  }

  public uint[][] getStationen()
  {
    uint[][] stats = [];
    for(uint i = 0; i < karte.GetLength(0); i++)
    {
      for(uint j = 0; j < karte.GetLength(1) ; j++)
      {
        if(karte[i,j].istStation())
        {
          stats.Append([i, j]);
        }
      }
    }
    return stats;
  }

  public uint[][] erstelleWeg(uint[][] ziele)
  {

    return null;
  }
  
  public BahnElement[,] Karte
    {
        get { return karte; }
        set { karte = value; }
    }
};