using UnityEngine;
using System.Collections;


public class CheckPoint : MonoBehaviour
{


    private Vector3 _position;

	// Use this for initialization
	void Start ()
    {
        _position.x = PlayerPrefs.GetFloat("CheckPointX");
        _position.y = PlayerPrefs.GetFloat("CheckPointY");
        _position.z = PlayerPrefs.GetFloat("CheckPointZ");


        // Hvis spillet er startet fra ny (restart) så sæt spillerens position til det seneste checkpoint
        if (_position != Vector3.zero)
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = _position;
        }
	}

    void Update()
    {

    }
	
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {

            PlayerPrefs.SetFloat("CheckPointX", transform.position.x);
            PlayerPrefs.SetFloat("CheckPointY", transform.position.y);
            PlayerPrefs.SetFloat("CheckPointZ", transform.position.z);
            print("Dit checkpoint er nu på: " + gameObject.name);
        }
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("CheckPointX", 0);
        PlayerPrefs.SetFloat("CheckPointY", 0);
        PlayerPrefs.SetFloat("CheckPointZ", 0);
    }

    void OnLevelWasLoaded(int level)
    {
        if (level != PlayerPrefs.GetInt("LastLoadedLevel", level))
        {
            // hvis dette level der blev loadet IKKE er det samme som sidste level...
            // så clear checkpoint
            PlayerPrefs.SetFloat("CheckPointX", 0);
            PlayerPrefs.SetFloat("CheckPointY", 0);
            PlayerPrefs.SetFloat("CheckPointZ", 0);
        }
    }
}
