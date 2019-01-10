using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {


    void Start () {
      Input.gyro.enabled = true;
	}

	void Update () {
        
        // Mobile controls
        Vector3 input = Input.gyro.gravity*10;
        Physics.gravity = new Vector3(input.x, -20, input.y);

        //PC Controls
        if (Input.GetKey(KeyCode.D))
        {
            Physics.gravity = new Vector3(5.0F, -20.0F, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
                Physics.gravity = new Vector3(-5.0F, -20.0F, 0);
            }
        if (Input.GetKey(KeyCode.W))
        {
                Physics.gravity = new Vector3(0, -20.0F, 5.0F);
            }
        if (Input.GetKey(KeyCode.S))
        {
            Physics.gravity = new Vector3(0, -20.0F, -5.0F);
        }
    }
}
