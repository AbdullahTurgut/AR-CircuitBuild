using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorRightPoint : MonoBehaviour
{
    public int reactorRightCount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "ReactorRightPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorRightCount = 1;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorRightCount = 1;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorRightCount = 1;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorRightCount = 1;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorRightCount = 1;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorRightCount = 1;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorRightCount = 1;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorRightCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "ReactorRightPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorRightCount = 0;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorRightCount = 0;

        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorRightCount = 0;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorRightCount = 0;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorRightCount = 0;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorRightCount = 0;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorRightCount = 0;
        }
        else if (gameObject.name == "ReactorRightPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorRightCount = 0;
        }
    }
}