using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyForce : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="character")
        {
            rb.AddForce(Vector3.up * speed * Time.deltaTime);
            rb.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
