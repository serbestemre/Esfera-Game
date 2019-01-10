using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinPlane : MonoBehaviour {

    public GameObject canvas;
    public int ball;
    public static int i=1;

    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        ball--;
    }
	
	void Update ()
    {
        
        if (ball== 0) { 
        canvas.SetActive(true);
            SceneManager.LoadScene(i);
            i++;
            if (i == 8)
            {
                
                i = 1;
            }
        }
        
    }
}
