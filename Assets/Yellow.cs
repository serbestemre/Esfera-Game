using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{

    public GameObject green;
    AudioSource sound;

    private void Start()
    {
        sound = GameObject.Find("Yellow Sound").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Yellow Trigger")
        { 
            green.SetActive(true);
            sound.Play();
            other.gameObject.SetActive(false);
        }
    }
}