using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class AutoBounce : MonoBehaviour
{

    public float HoppeAfstand = 400;
    public float HoppeInterval = 1.5f;

    private bool _hasTouchedGround = true;


	// Use this for initialization
	IEnumerator Start ()
    {

        while(true)
        {
            if (_hasTouchedGround)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * HoppeAfstand);
            }

            yield return new WaitForSeconds(HoppeInterval);
        }
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        _hasTouchedGround = true;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        _hasTouchedGround = false;
    }
	

}
