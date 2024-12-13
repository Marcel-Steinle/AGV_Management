public class Auftrag
{
    
    //Variablen der Klasse Auftrag

    private uint auftragID;
    private uint[] startpunkt;
    private uint[] endpunkt; 
    private uint prioritaet; 
    private uint status; // 0 = Ausstehend, 1 = In Bearbeitung, 2 = Erledigt


    // Getter & Setter

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

    // Konstruktor der Klasse Auftrag
    public Auftrag(uint auftragID, uint[] startpunkt, uint[] endpunkt, uint prioritaet, uint status = 0)
    {
        this.auftragID = auftragID;
        this.startpunkt = startpunkt;
        this.endpunkt = endpunkt;
        this.prioritaet = prioritaet;
        this.status = status;
    }
}