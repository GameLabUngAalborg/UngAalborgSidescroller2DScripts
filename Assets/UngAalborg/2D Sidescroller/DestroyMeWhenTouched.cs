using UnityEngine;
using System.Collections;

public class DestroyMeWhenTouched : MonoBehaviour {

	// Ødelægger sig selv hvis det bliver rørt af et andet objekt med rigidbody2d på

    public bool MustHaveThisTag;  // Hvis du sætter kryds i denne i inspectoren (at den bliver 'true') så tjekker den om den har "TagName" tagget før den destroyer
    public string TagName = "Player";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == TagName)
        {
            Destroy(gameObject);
        }
    }


    // Vi tjekker hvad der rammer dens Trigger....
    void OnCollisionEnter2D(Collision2D other)
    {
      
        if (other.gameObject.tag == TagName)
        {
            Destroy(gameObject);
        }

    }

}
