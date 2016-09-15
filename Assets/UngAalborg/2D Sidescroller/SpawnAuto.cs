using UnityEngine;
using System.Collections;

public class SpawnAuto : MonoBehaviour
{
    public GameObject ObjektDerSkalSpawnes;
    public float SpawnSekunderInterval;
    public bool HarEnMaxLevetid;
    public float Levetid;
    public bool HarEtMaxAntalGange;
    public int AntalSpawn;

	// Use this for initialization
	IEnumerator Start () {

        if(HarEtMaxAntalGange)
        {
            for(int i = 0; i < AntalSpawn; i++)
            {

                GameObject obj = Instantiate(ObjektDerSkalSpawnes) as GameObject;
                obj.transform.position = transform.position;

                if(HarEnMaxLevetid)
                {
                    Destroy(obj, Levetid);
                }

                yield return new WaitForSeconds(SpawnSekunderInterval);
            }
        }
        else
        {
            while(gameObject.activeSelf)
            {
                GameObject obj = Instantiate(ObjektDerSkalSpawnes) as GameObject;
                obj.transform.position = transform.position;

                if (HarEnMaxLevetid)
                {
                    Destroy(obj, Levetid);
                }

                yield return new WaitForSeconds(SpawnSekunderInterval);
            }
        }
	
	}
	

}
