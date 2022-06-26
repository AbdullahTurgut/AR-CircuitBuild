using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorLeftPoint : MonoBehaviour
{
    public int reactorLeftCount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorLeftCount = 1;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorLeftCount = 1;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorLeftCount = 1;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorLeftCount = 1;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorLeftCount = 1;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorLeftCount = 1;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorLeftCount = 1;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            reactorLeftCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorLeftCount = 0;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorLeftCount = 0;

        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorLeftCount = 0;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorLeftCount = 0;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorLeftCount = 0;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorLeftCount = 0;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorLeftCount = 0;
        }
        else if (gameObject.name == "ReactorLeftPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            reactorLeftCount = 0;
        }
    }
}