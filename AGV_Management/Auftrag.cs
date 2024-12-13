public class Auftrag
{
    uint auftragID;
    uint[] startpunkt;
    uint[] endpunkt; 
    uint prioritaet; 
    uint status; 

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