using UnityEngine;
using System.Collections;

public class DisableAfterSeconds : MonoBehaviour {

    public float Sekunder = 2;

    private float Counter = 0;

    void Start()
    {
        Counter = Sekunder;
    }

	void Update()
    {
        Counter -= Time.deltaTime;
        if(Counter <= 0)
        {
            Counter = 2;
            gameObject.SetActive(false);
        }      
    }
	
}
