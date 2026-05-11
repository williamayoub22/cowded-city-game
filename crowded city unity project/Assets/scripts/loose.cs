using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loose : MonoBehaviour
{
    //normal texts
    public Text GameOverText;
    // GameObject
    public GameObject cars;
    public GameObject policeCar;
    //button images
    public Image tryAgainButtonImage;
    public Image mainMenuButtonImage;
    public Image exitButtonImage;
    //button text
    public Text tryAgainButtonText;
    public Text mainMenuText;
    public Text exitButtonText;
    //scripts
    public carmovment CarMovmentScript;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "loose")
        {
            // normal text
            GameOverText.enabled = true;
            // button images
            tryAgainButtonImage.enabled = true;
            mainMenuButtonImage.enabled = true;
            exitButtonImage.enabled = true;
            // button texts
            tryAgainButtonText.enabled = true;
            mainMenuText.enabled = true;
            exitButtonText.enabled = true;
            // scripts
            CarMovmentScript.enabled = false;
            cars.SetActive(false);
            policeCar.SetActive(false);


        }
            
    }


}
