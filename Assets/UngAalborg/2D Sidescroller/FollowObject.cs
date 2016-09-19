using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class FollowObject : MonoBehaviour {

    public GameObject ObjectToFollow;
    public float Speed;

    public enum Movement { Addforce, Velocity}
    public Movement MovementType;

    void Start()
    {
       
    }


	void FixedUpdate ()
    {
        Vector3 calc = ObjectToFollow.transform.position - transform.position;
        calc.Normalize();
        transform.right = calc;

        if (MovementType == Movement.Addforce)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * Speed * Time.deltaTime);
        }
        else if(MovementType == Movement.Velocity)
        {
            GetComponent<Rigidbody2D>().velocity = transform.right * Speed * Time.deltaTime;
        }
	
	}
}
