using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class AddForceOnSpawn : MonoBehaviour {

    public float Speed = 10;
    public Vector2 Force = Vector2.right;
    public bool AwayFromPlayer = false;

	// Use this for initialization
	void Start ()
    {

        if(AwayFromPlayer)
        {
            GameObject p = GameObject.FindGameObjectWithTag("Player");
            if(p.transform.position.x > transform.position.x)
            {
                //go left
                GetComponent<Rigidbody2D>().AddForce(Speed * Vector2.left, ForceMode2D.Impulse);
            }
            else
            {
                GetComponent<Rigidbody2D>().AddForce(Speed * Vector2.right, ForceMode2D.Impulse);
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(Speed * Force, ForceMode2D.Impulse);
        }


	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
