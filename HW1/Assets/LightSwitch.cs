using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public InputActionReference action;
    public new Light light;
    private bool isYellow = false;

    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (isYellow)
            {
                light.color = Color.white;
            }
            else
            {
                light.color = Color.yellow;
            }

            isYellow = !isYellow;
        };
    }
}
