using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotator : MonoBehaviour
{
    public static float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
