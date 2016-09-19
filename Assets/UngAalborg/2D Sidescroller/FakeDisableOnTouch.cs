using UnityEngine;
using System.Collections;

public class FakeDisableOnTouch : MonoBehaviour {

    public string Tag = "Player";

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == Tag)
        {
            if (GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
            if (GetComponent<Collider2D>() != null)
            {
                GetComponent<Collider2D>().enabled = false;
            }

        }
    }
	
	
}
