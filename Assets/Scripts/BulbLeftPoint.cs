using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbLeftPoint : MonoBehaviour
{
    public int bulbLeftCount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "BulbLeftPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbLeftCount = 1;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbLeftCount = 1;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbLeftCount = 1;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbLeftCount = 1;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbLeftCount = 1;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbLeftCount = 1;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbLeftCount = 1;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbLeftCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "BulbLeftPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbLeftCount = 0;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbLeftCount = 0;

        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbLeftCount = 0;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbLeftCount = 0;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbLeftCount = 0;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbLeftCount = 0;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbLeftCount = 0;
        }
        else if (gameObject.name == "BulbLeftPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbLeftCount = 0;
        }
    }
}
