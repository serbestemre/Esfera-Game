using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    AudioSource sound;
    public int hp = 3;

    void Start()
    {
        sound = GameObject.Find("Wall hit").GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.collider.name == "Sphere") {
            hp--;
            sound.Play();
        }
    }

    void Update()
    {
        if(hp <=0)
        {
            gameObject.SetActive(false);
        }
    }
}

