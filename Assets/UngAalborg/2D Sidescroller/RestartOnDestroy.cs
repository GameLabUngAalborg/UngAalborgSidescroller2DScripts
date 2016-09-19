using UnityEngine;
using System.Collections;

public class RestartOnDestroy : MonoBehaviour {

    public GameObject RestartHvisDetteObjectBliverDestroyed;

    public float RestartEfterSekunder = 1;

    void Start()
    {
        if(RestartHvisDetteObjectBliverDestroyed == null)
        {
            RestartHvisDetteObjectBliverDestroyed = GameObject.FindGameObjectWithTag("Player");
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
	
        if(RestartHvisDetteObjectBliverDestroyed == null)
        {
            StartCoroutine(Restart());
        }

	}

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(RestartEfterSekunder);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
