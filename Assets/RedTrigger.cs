using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class RedTrigger : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Cam;
    AudioSource sound;

    IEnumerator LoadScene()
    { 
        yield return new WaitForSeconds(2f);
        Physics.gravity = new Vector3(0, -20.0f, 0);
        SceneManager.LoadScene(WinPlane.i-1);
    }   

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Red Trigger") {
                
            Cam.GetComponent<Gravity>().enabled = (false);
            Physics.gravity = new Vector3(0, +100.0F, 0);
            Canvas.SetActive(true);
            sound.Play();
            StartCoroutine("LoadScene");
        }
    }

    void Start ()
    {
        sound = GameObject.Find("Red Sound").GetComponent<AudioSource>();
    }
	
}
