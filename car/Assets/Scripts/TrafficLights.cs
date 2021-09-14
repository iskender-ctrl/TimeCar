using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{
    public Material red;
    public Material yellow;
    public Material green;
    public GameObject wall;
    public float redTime, yellowTime, greenTime, time;
    private GameObject CarsMove;
    void Start()
    {
        red.DisableKeyword("_EMISSION");
        yellow.DisableKeyword("_EMISSION");
        CarsMove = GameObject.FindGameObjectWithTag("Cars");
    }

    // Update is called once per frame
    void Update()
    {
        if (time<greenTime)
        {
            time += Time.deltaTime;
        }
        else
        {
            time = 0;
        }
        if (time<redTime)
        {
            red.EnableKeyword("_EMISSION");
            yellow.DisableKeyword("_EMISSION");
            green.DisableKeyword("_EMISSION");
            wall.SetActive(false);
        }
        if (time>redTime&&time<yellowTime)
        {
            red.DisableKeyword("_EMISSION");
            yellow.EnableKeyword("_EMISSION");
            green.DisableKeyword("_EMISSION");
            wall.SetActive(true);
        }
        if (time>yellowTime)
        {
            red.DisableKeyword("_EMISSION");
            yellow.DisableKeyword("_EMISSION");
            green.EnableKeyword("_EMISSION");
            wall.SetActive(true);
        }
    }
}
