using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public Slider Volume;
    public AudioSource Music;
	
	// Update is called once per frame
	void Update () {
        Music.volume = Volume.value;
	}
}
