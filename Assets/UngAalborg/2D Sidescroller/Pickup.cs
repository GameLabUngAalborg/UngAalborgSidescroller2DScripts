using UnityEngine;
using System.Collections;

/// <summary>
/// Hvis der kommer et andet objekt ind i dette objekt med tagget "TagName" så bliver det Destroyed.
/// </summary>
public class Pickup : MonoBehaviour 
{
    // En public string
    // public fordi vi vil ændre på den i inspectoren
    // string fordi det er en tekst
    // TagName er navnet på variablen
    // Vi sætter tagname til at være "Player" (med gåseøjne, som man skal når det er en tekst).
    // Så det er kun spilleren der kan tage tingen. Men det kan ændres hvis man får nogle gode idéer...
	public string TagName = "Player";

    // Vi tjekker hvad der rammer dens Trigger....
	void OnTriggerEnter2D(Collider2D other)
	{
        // Hvis det der ramte har en tag som er lig med "TagName" (som per standard er "Player")
		if (other.tag == TagName)
		{
            // Så destroyed vi dette objekt
            Destroy(gameObject);

            // Vi laver et print til konsollen for at skrive ud at den er samlet op
            print("Du samlede en "+gameObject.name+" op!");
		}
	}

	// Hvis du ikke satte den til en trigger, så vil der ske en collision.
	void OnCollisionEnter2D(Collision2D other)
	{
		// Hvis det der ramte har en tag som er lig med "TagName" (som per standard er "Player")
		if (other.gameObject.tag == TagName)
		{
			// Så destroyed vi dette objekt
			Destroy(gameObject);

			// Vi laver et print til konsollen for at skrive ud at den er samlet op
			print("Du samlede en "+gameObject.name+" op!");
		}
	}

}
