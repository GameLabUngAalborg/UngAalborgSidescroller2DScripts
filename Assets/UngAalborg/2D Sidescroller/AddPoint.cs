using UnityEngine;
using System.Collections;

public class AddPoint : MonoBehaviour 
{
    // Dette er en reference til det component der hedder ScoreManager som ligger på et andet GameObject
    // Den skal du selv finde ude i inspectoren. 
    public ScoreManager ReferenceTilScoreManager;
    public int AntalPoint;

    // Når dette objektet bliver slettet så vil den køre dette kode inden
    void OnDestroy()
    {
        // Vi sætter variablen score til at blive plusset med AntalPoint.
        ReferenceTilScoreManager.Score += AntalPoint;

    }
}
