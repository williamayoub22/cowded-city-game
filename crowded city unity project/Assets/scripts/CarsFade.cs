using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarsFade : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "end")
        {
            Destroy(gameObject);
        }

    }


}