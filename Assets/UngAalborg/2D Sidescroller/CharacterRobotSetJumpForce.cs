using UnityEngine;
using System.Collections;

public class CharacterRobotSetJumpForce : MonoBehaviour
{

    public float PlayerJumpForce = 1000;
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent< UnityStandardAssets._2D.PlatformerCharacter2D>())
        {

            other.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_JumpForce = PlayerJumpForce;






        }
    }

 
}
