public class Auftrag
{
    private uint auftragID;
    private uint[] startpunkt;
    private uint[] endpunkt; 
    private uint prioritaet; 
    private uint status;

    public uint AuftragID
    {
        get { return auftragID; } 
        //set { auftragID = value; }
    }

    public uint[] Startpunkt
    {
        get { return startpunkt; }
        //set { startpunkt = value; }
    }

    public uint[] Endpunkt
    {
        get { return endpunkt; }
        //set { endpunkt = value; }
    }

    public uint Prioritaet
    {
        get { return prioritaet; }
        //set { prioritaet = value; }
    }

    public uint Status
    {
        get { return status; }
        set { status = value; }
    }

    public Auftrag(uint auftragID, uint[] startpunkt, uint[] endpunkt, uint prioritaet, uint status)
    {
        this.auftragID = auftragID;
        this.startpunkt = startpunkt;
        this.endpunkt = endpunkt;
        this.prioritaet = prioritaet;
        this.status = status;
    }
    public void setStatus(uint status)
    {
        this.status = status; 
    }
    public uint getStatus()
    {
        return this.status; 
    }
}