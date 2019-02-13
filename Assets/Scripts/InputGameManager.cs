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
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        if (m_targetIndicator != null)
            m_targetIndicator.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Check for the mouse being down, if true, activate the targetIndicator
        if (Input.GetMouseButtonDown(0))
        {
            if (m_targetIndicator != null && !m_targetIndicator.activeInHierarchy)
                m_targetIndicator.SetActive(true);

            RaycastHit hitInfo = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                m_targetPosition = hitInfo.point;
            }

            m_targetIndicator.transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y + .1f, hitInfo.point.z);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            m_okToMove = true;
            m_targetIndicator.SetActive(false);
        }

    }

    //If the microphone is loud, change the okToMove flag to true and #endregion
    //De-activate the indicator if it's OK to move and set the target position
    public void ItsOKtoMove()
    {
        if (!m_okToMove)
        {
            m_okToMove = true;
            Invoke("ResetMove", 3f);
        }

    }

    public Vector3 GetDestinationPoint()
    {
        return m_targetPosition;
    }

    void ResetMove()
    {
        m_okToMove = false;
    }


}
