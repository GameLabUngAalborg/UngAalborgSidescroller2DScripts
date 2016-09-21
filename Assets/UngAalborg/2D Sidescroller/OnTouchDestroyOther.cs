using UnityEngine;
using System.Collections;

public class OnTouchDestroyOther : MonoBehaviour {

	public string TagName = "Player";
	public GameObject GameObjectToDestroy;


	void OnDrawGizmos()
	{
		Gizmos.color = new Color (1, 0, 0, 0.2f);
		if (GetComponent<SpriteRenderer> () == null) 
		{

			if (GetComponent<BoxCollider2D> ())
			{
				BoxCollider2D b = GetComponent<BoxCollider2D> ();
				Gizmos.DrawCube(new Vector3(transform.position.x+b.offset.x*transform.localScale.x, transform.position.y+b.offset.y*transform.localScale.y, transform.position.z), new Vector3(b.size.x*transform.localScale.x, b.size.y*transform.localScale.y, 0));


			}

		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == TagName)
		{
			Destroy(GameObjectToDestroy);
		}
	}


	// Vi tjekker hvad der rammer dens Trigger....
	void OnCollisionEnter2D(Collision2D other)
	{

		if (other.gameObject.tag == TagName)
		{
			Destroy(GameObjectToDestroy);
		}

	}




}
