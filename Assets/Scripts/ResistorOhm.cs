using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResistorOhm : MonoBehaviour
{
    public float _resistorOhm;

    public void Update()
    {
        if (gameObject.name == "Resistor5ohm")
        {
            _resistorOhm = 5f;
        }
        if (gameObject.name == "Resistor10ohm")
        {
            _resistorOhm = 10f;
        }
        if (gameObject.name == "Resistor20ohm")
        {
            _resistorOhm = 20f;
        }
    }
}
