using UnityEngine;
using System.Collections;

public class OnTouchAddToCounter : MonoBehaviour {

    public string HasThisTag = "Player";
    public int PointToAdd = 1;

    public Counter CounterToAddPoint;

	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.tag == HasThisTag)
        {
            CounterToAddPoint.CurrentAmountOfPoints += PointToAdd;
            print("Added " + PointToAdd + " to "+CounterToAddPoint.name+" counter");
        }
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == HasThisTag)
        {
            CounterToAddPoint.CurrentAmountOfPoints += PointToAdd;
            print("Added " + PointToAdd + " to " + CounterToAddPoint.name + " counter");
        }

    }
}
