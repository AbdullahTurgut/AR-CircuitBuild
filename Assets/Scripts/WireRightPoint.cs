using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireRightPoint : MonoBehaviour
{
    public int wireRightCount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "WireRightPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireRightCount = 1;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireRightCount = 1;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireRightCount = 1;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireRightCount = 1;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireRightCount = 1;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireRightCount = 1;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireRightCount = 1;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireRightCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "WireRightPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireRightCount = 0;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireRightCount = 0;

        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireRightCount = 0;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireRightCount = 0;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireRightCount = 0;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireRightCount = 0;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireRightCount = 0;
        }
        else if (gameObject.name == "WireRightPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireRightCount = 0;
        }
    }
}
