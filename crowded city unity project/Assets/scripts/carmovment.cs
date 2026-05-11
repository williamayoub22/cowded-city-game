using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmovment : MonoBehaviour {
    public float forwardspeed = 6.0f;
    public float rightLeftSpeed = 4.0f;
    public float backspeed = 3.0f;
    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject wheel3;
    public GameObject wheel4;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * Time.deltaTime * forwardspeed;
           GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
            wheel1.transform.Rotate(8, 0, 0);
            wheel2.transform.Rotate(8, 0, 0);
            wheel3.transform.Rotate(8, 0, 0);
            wheel4.transform.Rotate(8, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * Time.deltaTime * backspeed;
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
           wheel1.transform.Rotate(-8, 0, 0);
            wheel2.transform.Rotate(-8, 0, 0);
            wheel3.transform.Rotate(-8, 0, 0);
            wheel4.transform.Rotate(-8, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * Time.deltaTime * rightLeftSpeed;
            GetComponent<Transform>().eulerAngles = new Vector3(0, -15, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * Time.deltaTime * rightLeftSpeed;
            GetComponent<Transform>().eulerAngles = new Vector3(0, 15, 0);
        }


        if (Input.GetKey("d") & Input.GetKey("s"))
        {
            transform.position += Vector3.right * Time.deltaTime * backspeed;
            GetComponent<Transform>().eulerAngles = new Vector3(0, -15, 0);
            wheel1.transform.Rotate(-8, 0, 0);
            wheel2.transform.Rotate(-8, 0, 0);
            wheel3.transform.Rotate(-8, 0, 0);
            wheel4.transform.Rotate(-8, 0, 0);
        }
        if (Input.GetKey("a") & Input.GetKey("s"))
        {
            transform.position += Vector3.left * Time.deltaTime * backspeed;
            GetComponent<Transform>().eulerAngles = new Vector3(0, 15, 0);
            wheel1.transform.Rotate(-8, 0, 0);
            wheel2.transform.Rotate(-8, 0, 0);
            wheel3.transform.Rotate(-8, 0, 0);
            wheel4.transform.Rotate(-8, 0, 0);
        }
    }
}
