using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // bruges til at skifte mellem scener.

public class OnTouchChangeLevel : MonoBehaviour 
{

    public string TagName = "Player";
    public string SceneNavn;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == TagName)
        {
            SceneManager.LoadScene(SceneNavn);
        }

    }
}
