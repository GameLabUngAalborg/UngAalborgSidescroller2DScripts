using UnityEngine;
using System.Collections;

/// <summary>
/// Hvis man går ind i en triggercollider der har et tag med "Ladder" så vil kontrollen her tage over. 
/// </summary>
public class Ladder : MonoBehaviour 
{

	public KeyCode Up = KeyCode.W;
	public float LadderSpeed = 125;


	void OnTriggerStay2D(Collider2D other) 
	{
		if (other.tag == "Ladder")
		{

			if (Input.GetKey (Up)) 
			{
				GetComponent<Rigidbody2D> ().velocity = Vector2.up * Time.deltaTime * LadderSpeed;
			}



		}
	}
}
