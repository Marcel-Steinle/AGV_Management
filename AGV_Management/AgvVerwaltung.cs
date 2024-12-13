public class AgvVerwaltung
{
    
    // Variablen der Klasse AgvVerwaltung
    
    private List<Agv>? agvs;

    // Getter & Setter

    public List<Agv> Avgs
    {
        get { return this.agvs; }
        set { this.agvs = value; }
    }

    // Konstruktor der Klasse AgvVerwaltung
    public AgvVerwaltung (List<Agv>? agvs = null)
    {
        this.agvs = agvs;
    }


    // Methoden der Klasse AgvVerwaltung
    // 
    public void execute()
    {

    }

    // Gibt einen AGV zurück, der bereit ist, einen Auftrag anzunehmen
    public Agv einAgvBereit()
    {
        foreach (Agv a in agvs)
        {
            if (a.Position == a.Station && a.Auftrag.Status == 2)
            {
                return a;
            }
        }
        return null;
    }

    // Weist einen Auftrag einem AGV zu
    public bool auftragZuweisen(Auftrag auftrag, Agv agv)
    {
        return true;
    }
}