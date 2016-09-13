using UnityEngine;
using System.Collections;
using UnityEngine.UI; // VIGTIGT

public class ScoreManager : MonoBehaviour {

    // Vi har en public decimaltal som hedder Score til at holde øje med point. 
    public float Score = 0;

    // For at vi kan sætte en text i spillet til at vise points
    // Så skal vi skrive "Using UnityEngine.UI;" oppe i toppen Det er VIGTIGT!
    // Så kan vi nu lave en text variable
    public Text ScoreText;


	
	// Update is called once per frame
	void Update ()
    {
	
        // Hver frame sætter den tekst objektes tekst til at være scoren
        ScoreText.text = "Din score: "+Score;

	}
}
