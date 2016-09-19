using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class HealthStarPowerup : MonoBehaviour
{
    public float StarPowerTime = 5;
    public AudioClip SoundWhileInStarPower;





    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
           
            StartCoroutine(StarPower(other));
        }
    }

    IEnumerator StarPower(Collider2D c)
    {
        Health h = c.GetComponent<Health>();
        h._invincible = true;
        h._damageOnTouch = true;

        GetComponent<AudioSource>().clip = SoundWhileInStarPower;
        GetComponent<AudioSource>().Play();

        SpriteRenderer r = c.GetComponent<SpriteRenderer>();

        for(float t = 0; t < StarPowerTime; t+=Time.deltaTime)
        {
            r.color = new Color(Random.value, Random.value, Random.value);      
            yield return null;
        }

        r.color = Color.white;

        h._invincible = false;
        h._damageOnTouch = false;
        GetComponent<AudioSource>().Stop();
    }
}
