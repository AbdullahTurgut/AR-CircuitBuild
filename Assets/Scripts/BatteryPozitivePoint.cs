using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPozitivePoint : MonoBehaviour
{
    public int batteryPoizitveCount;
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
        if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryPoizitveCount = 1;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryPoizitveCount = 1;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryPoizitveCount = 1;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryPoizitveCount = 1;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryPoizitveCount = 1;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryPoizitveCount = 1;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryPoizitveCount = 1;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            batteryPoizitveCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryPoizitveCount = 0;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryPoizitveCount = 0;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryPoizitveCount = 0;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryPoizitveCount = 0;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryPoizitveCount = 0;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryPoizitveCount = 0;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryPoizitveCount = 0;
        }
        else if (gameObject.name == "BatteryPozitivePoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            batteryPoizitveCount = 0;
        }
    }
}