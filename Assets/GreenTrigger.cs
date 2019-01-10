using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTrigger : MonoBehaviour
{
    AudioSource sound;

    void Start()
    {
        sound = GameObject.Find("Green Sound").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Green Trigger")
        {
            gameObject.layer = 10;
            sound.Play();
        }
    }
}
