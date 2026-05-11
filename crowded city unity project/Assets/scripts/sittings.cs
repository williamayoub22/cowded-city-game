using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sittings : MonoBehaviour {

    public AudioMixer audioMixer;

    public void SetSound (float sound)

    {
        audioMixer.SetFloat("SittingsSound", sound);
    }

}
