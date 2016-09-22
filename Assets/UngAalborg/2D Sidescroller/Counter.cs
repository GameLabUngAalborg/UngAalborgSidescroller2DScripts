using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {

    public int CurrentAmountOfPoints = 0;
    public int PointsToActivateGameObject = 1;
    public GameObject GameObjectToActivate;
    public bool ResetCountAfterActivate = false;
	
	// Update is called once per frame
	void Update ()
    {
	    if(CurrentAmountOfPoints >= PointsToActivateGameObject)
        {
            GameObjectToActivate.SetActive(true);
          

            if(ResetCountAfterActivate)
            {
                CurrentAmountOfPoints = 0;
            }
        }
	}
}
