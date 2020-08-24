using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    private string theCollider;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();

    }


    void OnTriggerEnter(Collider other)
    {
        theCollider = other.tag;
        if (theCollider == "Player")
        {
            audio.Play();
            audio.loop = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        theCollider = other.tag;
        if (theCollider == "Player")
        {
            audio.Stop();
            audio.loop = false;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
