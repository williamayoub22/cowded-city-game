using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelsRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(6, 0, 0);
    }
}
