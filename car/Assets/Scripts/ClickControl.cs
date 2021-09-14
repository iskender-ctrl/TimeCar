using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickControl : MonoBehaviour
{
    public GameObject bttn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void click()
    {
        Shot.clickControl = true;
        bttn.gameObject.SetActive(false);
    }


}
