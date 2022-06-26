using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryNegativePoint : MonoBehaviour
{
    public int batteryNegativeCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryNegativeCount = 1;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryNegativeCount = 1;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryNegativeCount = 1;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryNegativeCount = 1;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryNegativeCount = 1;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryNegativeCount = 1;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryNegativeCount = 1;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryNegativeCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryNegativeCount = 0;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryNegativeCount = 0;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryNegativeCount = 0;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryNegativeCount = 0;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryNegativeCount = 0;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryNegativeCount = 0;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryNegativeCount = 0;
        }
        else if (gameObject.name == "BatteryNegativePoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryNegativeCount = 0;
        }
    }
}
