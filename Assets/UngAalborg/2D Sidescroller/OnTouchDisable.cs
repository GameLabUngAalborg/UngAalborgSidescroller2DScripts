using UnityEngine;
using System.Collections;

public class OnTouchDisable : MonoBehaviour {

    // Reference til det objekt vi vil enable
    public GameObject ObjectToDisable;

    public string TagName = "Player"; // Det tag som det andet objekt skal have for at det kan røre.


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == TagName)
        {
            //Vi disabler "ObjectToEnable"
            ObjectToDisable.SetActive(false);

        }
    }


    // Vi tjekker hvad der rammer dens Trigger....
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == TagName)
        {
            //Vi disabler "ObjectToEnable"
            ObjectToDisable.SetActive(false);
        }

    }
}
