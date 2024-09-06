using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class fademusicout : MonoBehaviour
{
    // Start is called before the first frame update
    
    public AudioSource source; // Assign in editor/etc
    public float fadeTime = 1f; // fade time in seconds
    private bool canmakelower = true;
    public void Start()
    {
        canmakelower = Nextlevel.musiconsound;
    }

    public void Update()
    {
        if (!canmakelower)
        {
            Debug.Log("!");

        }

        if (source.volume == 0)
        {
            Debug.Log(":)");
        }
    }

    


    
}
