//Yourname Here, Feb, 2019
//Based on a tutorial posted here: https://github.com/bryanrtboy/InputTutorial
//
//This script will be our central game manager, it should only exist once
//in the game, aka the Singleton pattern. The script will is based on the #endregion
//pseudocode Place Object with mouse. We need it to take a mouse position, and place
//a target based on a raycast. Then, the frogs need to know that a target exists.
//Secondly, we will use this to track if the frogs should start moving.
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputGameManager : MonoBehaviour
{
    public static InputGameManager instance;

    public GameObject m_targetIndicator;
    //[HideInInspector] //Each frog will check if this is true
    public bool m_okToMove = false;

    private Vector3 m_targetPosition = Vector3.zero;

    void Awake()
    {
        //Enforce the Singleton pattern, there can be only one InputGameManager in the scene

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Check for the mouse being down, if true, activate the targetIndicator


    }

    //If the microphone is loud, change the okToMove flag to true and #endregion
    //De-activate the indicator if it's OK to move and set the target position
    public void ItsOKtoMove()
    {

    }

}
