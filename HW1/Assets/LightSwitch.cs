using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();
    }
    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            light.color = Color.yellow;
        }
    }
}