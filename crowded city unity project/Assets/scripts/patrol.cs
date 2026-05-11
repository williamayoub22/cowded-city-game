using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour {

    public Transform[] patrolPoints;
    private int currentpoint;
    public float MoveSpeed;
	// Use this for initialization
	void Start () {
        transform.position = patrolPoints[0].position;
        currentpoint = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position == patrolPoints[currentpoint].position)
        {
            currentpoint++;
        }


        if (currentpoint >= patrolPoints.Length)
        {
            currentpoint = 0;
        }



        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentpoint].position, MoveSpeed * Time.deltaTime);
	}
}
