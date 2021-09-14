using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailActive : MonoBehaviour
{
    public static bool control;
    void Start()
    {
        gameObject.GetComponent<TrailRenderer>().emitting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(control==true)
        {
            gameObject.GetComponent<TrailRenderer>().emitting = true;
        }
        else
        {
            gameObject.GetComponent<TrailRenderer>().emitting = false;
        }
    }
}
