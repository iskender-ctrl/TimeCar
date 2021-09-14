using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossPeople : MonoBehaviour
{
    public Transform character;
    public ParticleSystem pof;
   public Animator anim;
    bool control;
    void Start()
    {
        control = true;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * 1 * Time.deltaTime);
        if(control==true)
        {
            anim.Play("Walk");
        }
        else
        {
            anim.Play("yaya-carpma");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="return")
        {
            gameObject.transform.Rotate(0, 180, 0);
        }
        if (other.gameObject.tag == "character")
        {
            control = false;
            StartCoroutine(timer());
            gameObject.transform.LookAt(character.transform.position);
        }
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(1);
        pof.Play();
        Destroy(gameObject);
       
    }
    
    
}
