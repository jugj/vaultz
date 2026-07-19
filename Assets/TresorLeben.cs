using UnityEngine;

public class TresorLeben : leben
{
    protected virtual void Sterben()
    {
        Debug.Log("Tresor wurde geknackt!");

        // Hier kannst du später Geld spawnen oder den Tresor öffnen.
        // Zum Testen bleibt der Tresor einfach stehen.
    }
}