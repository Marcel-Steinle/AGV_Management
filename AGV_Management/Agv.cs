public class Agv
{

    // Variablen der Klasse Agv

    private Auftrag? auftrag;
    private uint[] position;
    private uint[] station;
    private uint? richtung;
    private uint[][]? weg;

    // Getter & Setter

    public Auftrag Auftrag
    {
        get { return this.auftrag; }   // get method
        set { this.auftrag = value; }  // set method
    }

    public uint[] Position
    {
        get { return this.position; }
        set { this.position = value; }
    }

    public uint[] Station
    {
        get { return this.station; }
        set { this.station = value; }
    }

    public uint? Richtung
    {
        get { return this.richtung; }
        set { this.richtung = value; }
    }

    public uint[][] Weg
    {
        get { return this.weg; }
        set { this.weg = value; }
    }


    // Konstruktor der Agv-Klasse
    public Agv(uint[] station)
    {
        this.station = station;
        this.position = station;
    }

    // Methoden der Agv-Klasse
    // fährt einen Schritt entsprechend der Wegpunkt-Liste in weg[][]-Variable. Wenn "weg[][]" leer, dann generiere mehr mit findeWeg().
    public void fahre()
    {

    }

    // beendet den momentanen Auftrag und leitet den Parkprozess ein
    public void auftragBeenden(Auftrag auftrag)
    {
        if(this.Position == this.auftrag.Endpunkt)
        {
            this.weg = [];
            this.auftrag.Status = 2; // muss auch in der Auftragsverwaltung so notiert werden!
            fahre();
        }
    }

    // generiert die Wegpunkte, um zum nächsten Punkt zu kommen (Startpunkt, Endpunkt, Ladestation, etc.)
    public void findeWeg(Landkarte karte)
    {
        
    }

    // gibt zurück, ob das AGV bereits einen Auftrag besitzt
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

    //bricht den momentantn Auftrag ab (nicht status auf "fertig") und leitet den Parkprozess ein
    public void auftragAbbrechen()
    {
        
    }
}