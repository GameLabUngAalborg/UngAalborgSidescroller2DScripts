using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveLeftAndRightInSeconds : MonoBehaviour {

    public enum Retning { Højre, Venstre}
    public Retning StartRetning;
    public float Hastighed = 300;
    public float TidPerRetning = 1;
    public bool SkiftX = true;

    private Vector2 dir;
    private Rigidbody2D rb;


    // Use this for initialization
    IEnumerator Start()
    {

        Vector2 dir = Vector2.right;

        if(StartRetning == Retning.Venstre)
        {
            dir = Vector2.left;
        }

        rb = GetComponent<Rigidbody2D>();

        while (true)
        {
           
            

            for(float t = 0; t < TidPerRetning; t+= Time.deltaTime)
            {
             
                rb.velocity = dir * Time.deltaTime * Hastighed;
                // rb.AddForce(dir * Time.deltaTime * Hastighed, ForceMode2D.Impulse);
                yield return null;
            }
            

            if (dir == Vector2.right)
            {
                dir = Vector2.left;
              
            }
            else
            {
                dir = Vector2.right;
            }

            if(SkiftX)
            {
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            }

        }

    }


}
