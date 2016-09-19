using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveLeftAndRightOnCollision : MonoBehaviour {

    public enum Retning { Højre, Venstre}
    public Retning StartRetning;
    public float Hastighed = 300;
    public string CollisionTag = "Wall";
    public bool SkiftX = true;

    private Vector2 dir;
    private Rigidbody2D rb;


    // Use this for initialization
    IEnumerator Start()
    {
        dir = Vector2.right;

        if(StartRetning == Retning.Venstre)
        {
            dir = Vector2.left;
        }

        rb = GetComponent<Rigidbody2D>();

        while (true)
        {         
                rb.velocity = dir * Time.deltaTime * Hastighed;
                yield return null;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {


        if(other.gameObject.tag == "Wall")
        {

            if (dir == Vector2.right)
            {
                dir = Vector2.left;

            }
            else
            {
                dir = Vector2.right;
            }

            if (SkiftX)
            {
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            }
        }
    }


}
