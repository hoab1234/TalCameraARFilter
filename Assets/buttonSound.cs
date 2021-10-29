using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSound : MonoBehaviour
{


    private GameObject ButtonSound;
    AudioSource buttonClickSound;

    void Awake()
    {



        ButtonSound = GameObject.FindGameObjectWithTag("ButtonSound");


        DontDestroyOnLoad(transform.gameObject);

        buttonClickSound = GetComponent<AudioSource>();

    }

    public void PlayButtonSound()
    {
        buttonClickSound = GetComponent<AudioSource>();
        buttonClickSound.Play();
    }
}
