using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeUIChecker : MonoBehaviour {

    public Text TextToChange;
    private Health PlayerHealth;

	// Use this for initialization
	void Start () {

        PlayerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
	
	}
	
	// Update is called once per frame
	void Update () {


        TextToChange.text = PlayerHealth.Liv.ToString();
        


    }
}
