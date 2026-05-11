using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class win : MonoBehaviour {

    //game objects
    public GameObject cars;
    public GameObject policeCar;
    //normal texts
    public Text winning;
    //button images
    public Image nextButtonImage;
    public Image mainMenuButtonImage;
    public Image exitButtonImage;
    //button text
    public Text NextButtonText;
    public Text mainMenuText;
    public Text exitButtonText;
    //scripts
    public carmovment CarMovmentScript;



    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "end")
        {
            //normal texts
            winning.enabled = true;
            //button images
            nextButtonImage.enabled = true;
            mainMenuButtonImage.enabled = true;
            exitButtonImage.enabled = true;
            //button text
            NextButtonText.enabled = true;
            mainMenuText.enabled = true;
            exitButtonText.enabled = true;
            cars.SetActive(false);
            policeCar.SetActive(false);
            // scripts
            CarMovmentScript.enabled = false;
        }
    }
}
