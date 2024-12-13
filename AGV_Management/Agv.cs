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
        this.position = station;
        this.richtung = 0;
        this.auftrag = new Auftrag(0, [0, 0], [0, 0], 0, 2);
        this.weg = [];
    }

    public void fahre()
    {

    }

    public void auftragBeenden(Auftrag auftrag)
    {
        if(this.Position == this.auftrag.Endpunkt)
        {
            this.weg = [];
            this.auftrag.Status = 0; // WIP
        }
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

    public void auftragAbbrechen()
    {
        
    }
}