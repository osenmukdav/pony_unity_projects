using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion q = Input.gyro.attitude;
        float temp = q.z;
        q.z = q.y;
        q.y = temp;
        gameObject.transform.rotation = q;
    }
}
