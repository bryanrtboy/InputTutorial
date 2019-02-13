using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByJoystick : MonoBehaviour
{
    float h;
    float v;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //Debug.Log("Horizontal ais " + h.ToString() + ", Vertical is " + v.ToString());

        this.transform.Translate(new Vector3(h * .1f, 0, v * .1f));

    }
}
