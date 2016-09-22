using UnityEngine;
using System.Collections;

public class OnStartActivateScript : MonoBehaviour {

    public Behaviour ScriptToEnable;

    // Use this for initialization
    void OnEnable ()
    {
        ScriptToEnable.enabled = true;
	}
	
}
