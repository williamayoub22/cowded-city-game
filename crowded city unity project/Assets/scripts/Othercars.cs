using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Othercars : MonoBehaviour {
    public float carsSpeed = 5.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
            transform.position += Vector3.forward * Time.deltaTime * carsSpeed;
    }
}
