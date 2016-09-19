using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlayAudioOnTouch : MonoBehaviour {

    public AudioClip SoundToPlay;

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(SoundToPlay);
        }
    }
}
