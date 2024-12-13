using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

public class AuftragsVerwaltung 
{
    List<Auftrag> auftraege;

    public bool auftragHinzufuegen(Auftrag auftrag)
    {
        return true;
    }
    public Auftrag naechsterAuftrag()
    {
        return null; 
    }
    public Auftrag findeAuftrag(uint auftragID)
    {
        return null;
    }
    public bool auftragBereit()
    {
        return true;
    }
    public bool auftragAbschliessen(uint auftragID)
    {
        return true; 
    }
}
