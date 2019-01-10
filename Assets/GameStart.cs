using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    public GameObject Sphere;
    public GameObject Canvas;

	void Update ()
        {
        if (Input.GetMouseButtonDown(0))
        {
            Physics.gravity = new Vector3(0,-20.0F,0);
            Sphere.SetActive(true);
            Canvas.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}
}
