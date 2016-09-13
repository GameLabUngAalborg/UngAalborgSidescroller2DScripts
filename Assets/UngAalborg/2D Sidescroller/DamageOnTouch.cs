using UnityEngine;
using System.Collections;

/// <summary>
/// Dette script vil tjekke med enten en trigger eller en collision om der er et objekt der rammer den som har et "Health script"
/// Hvis det sker, så vil den gå ind på Health og trække liv fra.
/// </summary>
public class DamageOnTouch : MonoBehaviour 
{
	// Den første variable siger hvor meget skade den giver per gang.
	// Den er public så vi kan redigere i den ude i inspectoren.
	// int betyder det er et heltal, så vi kan ikke give 2.6 i skade f.eks.
	// At den er lig med 1 i starten, betyder at det er dens standard værdi hvis vi ikke ændre det i inspectoren.
	public int Skade = 1;


	// Vi bruger Unity's indbyggede funktioner
	// Vi bruger to forskellige fordi vi gerne vil have dette script til at virke selvom man har gjort sin collider
	// til en trigger eller ej.

	// Først tjekker vi triggeren
	void OnTriggerEnter2D(Collider2D other)
	{
		// Når der er et andet objekt (med en rigidbody2d) som rammer ind i dette objekt med scriptet på
		// Så sørger unity for at denne kode herinde under "OnTriggerEnter2D" bliver kørt.
		// Det andet objekts  bliver gemt i "other" 
		// Vi kan bruge en if sætning til at tjekke om other har et health komponent
		if (other.GetComponent<Health> () == true)
		{
			// Hvis det er sandt at den har et health komponent, så kører koden herinde!
			// Vi går ind på other (som er det objekt vi ramte..)
			// Så siger vi GetComponent<Health> for at få fat på Health componentet
			// Og så bruger vi den funktion (som er lavet på Health) som hedder TakeDamage
			// TakeDamage har brug for et argument, som er hvor meget skade den skal give
			// Så deri kunne vi enten skrive et tal eller variable, vi skrive variablen for det er den vi ændre i ude i inspectoren. 
			other.GetComponent<Health>().TakeDamage(Skade);
		}
	}

	// Collision er lidt anderledes, der er meget info i en "Collision2D"
	// Dette er når den ikke er en trigger
	void OnCollisionEnter2D(Collision2D other)
	{
		// for at kunne tjekke getcomponent, er vi nødt til at skrive det sådan i stedet (med .gameObject):
		if (other.gameObject.GetComponent<Health> () == true) 
		{
			// Vi kører kun denne kode hvis det andet objekt har et health component.
			other.gameObject.GetComponent<Health>().TakeDamage(Skade);


		}

	}


}
