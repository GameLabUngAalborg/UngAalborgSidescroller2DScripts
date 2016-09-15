using UnityEngine;
using System.Collections;

public class JetpackFunction : MonoBehaviour {

    public float Speed = 10;
    public float JetPackGravity = 5;
    public KeyCode Up = KeyCode.UpArrow, Down = KeyCode.DownArrow, Left = KeyCode.LeftArrow, Right = KeyCode.RightArrow;

    public float TidAktiv = 10;
 

    void OnEnable()
    {
        GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().enabled = false;
        GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().enabled = false;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Animator>().enabled = false;
        StartCoroutine(CountDownToDisable());
    }

    IEnumerator CountDownToDisable()
    {
        yield return new WaitForSeconds(TidAktiv);
        GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().enabled = true;
        GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().enabled = true;
        GetComponent<Rigidbody2D>().gravityScale = 3;
        GetComponent<Animator>().enabled = true;
        enabled = false;
    }

	void Update ()
    {
        Vector3 mov = Vector3.zero;

        if(Input.GetKey(Up))
        {
            mov += Vector3.up;
        }

        if (Input.GetKey(Down))
        {
            mov += Vector3.down;
        }

        if (Input.GetKey(Right))
        {
            mov += Vector3.right;
        }

        if (Input.GetKey(Left))
        {
            mov += Vector3.left;
        }

        mov.y -= JetPackGravity * Time.deltaTime;

        print(mov.y);

     //   if(mov.y < )

        transform.GetComponent<Rigidbody2D>().velocity = (mov * Time.deltaTime * Speed);





    }
}
