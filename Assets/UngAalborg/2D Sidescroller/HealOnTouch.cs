using UnityEngine;
using System.Collections;

public class HealOnTouch : MonoBehaviour
{

    public int AntalLivDenHealer = 1;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Health>())
        {
            //Den har et health script! Så nu kan vi give health...
            other.GetComponent<Health>().Heal(AntalLivDenHealer);
            
        }
    }

}