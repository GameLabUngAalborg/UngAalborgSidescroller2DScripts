﻿using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{

	public int Liv = 1; // Sætter liv til at være 1 som standard når man smider scriptet på et object. 

	private bool _invincible = false;  // siger at spilleren ikke er udødelig i starten 


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		//hvis liv er 0 eller derunder, så skal spilleren destroys.
		if (Liv <= 0) {

			// Så skal den Destroy "gameObject". Når der ikke står andet, så betyder det: "Det gameObject som scriptet ligger på". 
			Destroy(gameObject);

		}
	
	}

	public void TakeDamage(int SkadeTilSpilleren)
	{

		// Hvis spilleren ikke er udødelig, så mister han X antal liv.
		if (_invincible == false) {

			//trækker livet fra
			Liv -= SkadeTilSpilleren;
			//starter en coroutine der får den til at blinke
			StartCoroutine (SetInvincibleAndBlink (0.5f));

			//printer ud til konsollen hvor meget vi mistede
			print("Player lost "+SkadeTilSpilleren+" amount of health");
		}
	}



	public void Heal(int HealingTilSpilleren)
	{
		Liv += HealingTilSpilleren;
	}


	// Herunder er en coroutine til at få spilleren til at blive udødelig, så blinke og derefter bliver dødelig igen efter "tid" sekunder. 
	IEnumerator SetInvincibleAndBlink(float tid)
	{
		_invincible = true;


		StartCoroutine (Blink2 (0.1f, tid));
		yield return new WaitForSeconds (tid);
	

		_invincible = false;


	}

	// Denne coroutine (som bliver brugt ovenfor) gør at spilleren blinker hvert "BlinkInterval" interval over "tid" sekunder. 
	IEnumerator Blink2(float BlinkInterval, float tid)
	{

		SpriteRenderer sr = GetComponent<SpriteRenderer> ();


		for (int i = 0; i < (tid/BlinkInterval); i++)
		{
			if (sr.enabled) {
				sr.enabled = false;
			} else {
				sr.enabled = true;
			}

			yield return new WaitForSeconds(BlinkInterval);
		}

		sr.enabled = true;



	}


	void OnDestroy()
	{
		print ("The Player Died!");
	}
}
