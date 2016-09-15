using UnityEngine;
using System.Collections;

public class JetPackPowerup : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<JetpackFunction>() == null)
            {
                print("Du skal tilføje JetPackFunction til din spiller!");
            }
            else
            {
                other.GetComponent<JetpackFunction>().enabled = true;
            }
        }
    }
}
