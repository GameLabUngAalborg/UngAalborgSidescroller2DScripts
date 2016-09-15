using UnityEngine;
using System.Collections;

public class CharacterRobotSetSpeed : MonoBehaviour {

    public float PlayerSpeed = 15;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>())
        {

            other.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().m_MaxSpeed = PlayerSpeed;

        }
    }
}
