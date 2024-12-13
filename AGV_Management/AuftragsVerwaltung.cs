using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;

public class AuftragsVerwaltung 
{

    // Variablen der Klasse AuftragsVerwaltung

    List<Auftrag>? auftraege;



    // Getter & Setter

    public List<Auftrag>? Auftraege
    {
        get { return this.auftraege; }
        set { this.auftraege = value; }
    }

    // Konstruktor
    public AuftragsVerwaltung(List<Auftrag>? auftraege = null)
    {
        this.auftraege = auftraege;
    }

    // Methoden der Klasse AuftragsVerwaltung
    // Fügt einen Auftrag der Auftragsliste hinzu
    public bool auftragHinzufuegen(Auftrag auftrag)
    {
        return true;
    }

    // Gibt den nächsten Auftrag mit der höchsten Priorität aus der Auftragsliste
    public Auftrag naechsterAuftrag()
    {
        return null; 
    }

    // Findet einen Auftrag mit dessen ID aus der Auftragsliste
    public Auftrag findeAuftrag(uint auftragID)
    {
        return null;
    }

    // Gibt zurück, ob irgendein Auftrag bereit wäre, ausgeführt zu werden
    public bool auftragBereit()
    {
        return true;
    }

    // Schließt einen Auftrag anhand seiner ID ab
    public bool auftragAbschliessen(uint auftragID)
    {
        return true; 
    }
}
