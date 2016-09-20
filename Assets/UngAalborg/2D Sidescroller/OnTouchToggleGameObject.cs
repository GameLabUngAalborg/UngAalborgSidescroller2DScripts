using UnityEngine;
using System.Collections;

public class OnTouchToggleGameObject : MonoBehaviour {

    // Reference til det objekt vil vil toggle mellem 
    public GameObject ObjectToToggle;

    public string TagName = "Player"; // Det tag som det andet objekt skal have for at det kan røre.


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == TagName)
        {
			if (ObjectToToggle.activeSelf == true)
			{
				ObjectToToggle.SetActive (false);
			}
			else 
			{
				ObjectToToggle.SetActive (true);
			}

        }
    }


    // Vi tjekker hvad der rammer dens Trigger....
    void OnCollisionEnter2D(Collision2D other)
    {

		if (ObjectToToggle.activeSelf == true)
		{
			ObjectToToggle.SetActive (false);
		}
		else 
		{
			ObjectToToggle.SetActive (true);
		}

    }
}
