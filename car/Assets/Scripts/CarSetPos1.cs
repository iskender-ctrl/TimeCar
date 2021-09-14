using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSetPos1 : MonoBehaviour
{
    public Vector3 pos;
    public float destination;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x<=destination)
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="EndRoad")
        {
          
        }
    }

}
