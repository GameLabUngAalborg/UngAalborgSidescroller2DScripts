using UnityEngine;
using System.Collections;


/// <summary>
/// Skyder et objekt ud fra SpawnPosition
/// Du skal lave et GameObject som sidder som child til spilleren
/// Det objekt er der hvor der bliver spawnet. 
/// </summary>
public class Shoot : MonoBehaviour
{

    public GameObject SpawnPosition;
    public GameObject ObjectDerSkalSpawnes;

    public KeyCode KnapTilAtSkyde;
	
	// Update is called once per frame
	void Update () 
    {


        if (Input.GetKeyDown(KnapTilAtSkyde))
        {


        }
	
	}
}
