using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargerTrigger : MonoBehaviour {

    // Use this for initialization
    AudioSource sound;
    void Start()
    {
        sound = FindObjectOfType<AudioSource>();
    }
    public void OnTriggerEnter (Collider collider)
    {
        sound.Play();
    }
}
