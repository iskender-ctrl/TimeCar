using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsMove : MonoBehaviour
{
    private float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        if (Physics.Raycast(transform.position,transform.forward,3))
        {
            speed = 0;
        }
        else
        {
            speed = 5;
        }
    }
}
