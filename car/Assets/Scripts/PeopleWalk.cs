using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleWalk : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="left")
        {
            gameObject.transform.Rotate(0, -90, 0);
        }
       
    }

}
