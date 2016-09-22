using UnityEngine;
using System.Collections;

public class KameHameHa : MonoBehaviour {

    public KeyCode AttackKey = KeyCode.F;
    public GameObject KameHameHaHeadPrefab;
    public GameObject KameHameHaBeam, KameHameHaBeamStart;
    public GameObject SpawnPoint;
    public float TimeBeforeDestroy = 1;
    public bool DisableAfterShoot = false;

    private bool _isAttacking;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(AttackKey))
        {
            if (!_isAttacking)
            {
                StartCoroutine(KameHa());
                _isAttacking = true;
            }
        }
	
	}

    IEnumerator KameHa()
    {

        GameObject k = Instantiate(KameHameHaHeadPrefab) as GameObject;
        k.transform.position = SpawnPoint.transform.position;
        Destroy(k, TimeBeforeDestroy);
   
        Vector3 StayPosition = transform.position;

        GameObject beam = Instantiate(KameHameHaBeam) as GameObject;
        beam.transform.position = SpawnPoint.transform.position;

        GameObject BeamStart = Instantiate(KameHameHaBeamStart) as GameObject;
        BeamStart.transform.position = SpawnPoint.transform.position;

        Vector3 tmppos = SpawnPoint.transform.position;

        if(transform.position.x > k.transform.position.x)
        {
            k.transform.Rotate(0, 0, -180);
            BeamStart.transform.Rotate(0, 0, -180);
        }

        while(k != null )
        {
            transform.position = StayPosition;
            beam.GetComponent<LineRenderer>().SetPosition(0, tmppos);
            beam.GetComponent<LineRenderer>().SetPosition(1, k.transform.position);
            
            yield return null;

        }
        Destroy(beam);
        Destroy(BeamStart);

        print("kamehameha done");
        _isAttacking = false;
        if(DisableAfterShoot)
        {
            enabled = false;
        }

        yield break;
    }
}
