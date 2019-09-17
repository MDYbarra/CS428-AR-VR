﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARButtonFC : MonoBehaviour, IVirtualButtonEventHandler
{


    // AR Button
    public GameObject vbButtonObject;

    // Animated Tiger
    public GameObject tiger;

    // Back ground music crash bandicoot
    public AudioClip frontCoverBGMusic;
    public AudioSource aSourceFC;

    // Audio clip of title, authur, message
    public AudioSource aSourceName;
    public AudioClip frontCoverNameTitle;



    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("hello, You have just entered the Start() function");

        // Find AR Button
        vbButtonObject = GameObject.Find("VirtualButtonFC");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        // Find tiger
        tiger = GameObject.Find("Tiger");



        aSourceFC.clip = frontCoverBGMusic;
        aSourceName.clip = frontCoverNameTitle;

    }




    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");
        // Play Crash Bandicoot 1 time when pressed
        aSourceName.Play();

        // Tiger Animantion WALK
        tiger.GetComponent<Animation>().Play();



        // Small delayed added to clip to play while AR button
        // is held down intro clip will play
        aSourceFC.Play();

       
    }



    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");

        // Button is release intro clip stops
        aSourceName.Stop();

        // Tiger Animantion RUN
       // tiger.GetComponent<Animation>().Stop();


    }







}