using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BatteryVolt : MonoBehaviour
{
    public float _batteryVolt;


    public void Update()
    {
        if (gameObject.name == "Battery15Volt")
        {
            _batteryVolt = 15f;
        }
        if (gameObject.name == "Battery30Volt")
        {
            _batteryVolt = 30f;
        }
    }
}
