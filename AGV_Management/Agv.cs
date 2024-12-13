public class Agv
{
    private Auftrag auftrag;
    private uint[] position;
    private uint[] station;
    private uint richtung;
    private uint[][] weg;

    public Auftrag Auftrag
    {
        get { return auftrag; }   // get method
        set { auftrag = value; }  // set method
    }

    public uint[] Position
    {
        get { return position; }
        set { position = value; }
    }

    public uint[] Station
    {
        get { return station; }
        set { station = value; }
    }

    public uint Richtung
    {
        get { return richtung; }
        set { richtung = value; }
    }

    public uint[][] Weg
    {
        get { return weg; }
        set { weg = value; }
    }





    public Agv(uint[] station)
    {
        this.station = station;
    }

    public void fahre()
    {

    }

    public void auftragBeenden(Auftrag auftrag)
    {

    }

    public void findeWeg(Landkarte karte)
    {
        
    }

    public bool bereit()
    {
        if (this.auftrag != null)
        {
            return false;
        }
        else {
            return true;
        }
    }

    void auftragAbbrechen()
    {
        
    }
}