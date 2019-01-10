using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Background : MonoBehaviour {

    public GameObject sphere;
    public GameObject canvas;
    AudioSource sound;

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(2f);
        Physics.gravity = new Vector3(0, -20.0f, 0);
        SceneManager.LoadScene(WinPlane.i - 1);
    }

    public void OnTriggerEnter(Collider other)
    {
        sphere.SetActive(false);
        canvas.SetActive(true);
        sound.Play();
        StartCoroutine("LoadScene");
    }

    void Start () {
        sound = GameObject.Find("Fall Sound").GetComponent<AudioSource>();
    }
}
