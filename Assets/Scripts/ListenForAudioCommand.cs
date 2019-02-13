//Yourname Here, Feb, 2019
//Based on a tutorial posted here: https://github.com/bryanrtboy/InputTutorial
//
//This script will be take microphone input and check how loud it is
//if the input volume is over X amount, we will tell the InputGameManager
//that frogs should start moving. We could use Events and Delegates on the frogs
//but it's simpler to just tell the Game Manager when it's OK for them to move.
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenForAudioCommand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float db = MicInput.MicLoudnessinDecibels;

        if (db < 1 && db > -20f)
        {
            InputGameManager.instance.ItsOKtoMove();
        }

        Debug.Log("Volume is " + MicInput.MicLoudness.ToString("##.#####") + ", decibels is :" + MicInput.MicLoudnessinDecibels.ToString("######"));
        //Debug.Log("Volume is " + NormalizedLinearValue(MicInput.MicLoudness).ToString("#.####") + ", decibels is :" + NormalizedDecibelValue(MicInput.MicLoudnessinDecibels).ToString("#.####"));
    }


    float NormalizedLinearValue(float v)
    {
        float f = Mathf.InverseLerp(.000001f, .001f, v);
        return f;
    }

    float NormalizedDecibelValue(float v)
    {
        float f = Mathf.InverseLerp(-114.0f, 6f, v);
        return f;
    }
}
