using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireLeftPoint : MonoBehaviour
{
    public int wireLeftCount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "WireLeftPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireLeftCount = 1;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireLeftCount = 1;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireLeftCount = 1;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireLeftCount = 1;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireLeftCount = 1;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireLeftCount = 1;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireLeftCount = 1;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            wireLeftCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "WireLeftPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireLeftCount = 0;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireLeftCount = 0;

        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireLeftCount = 0;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireLeftCount = 0;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireLeftCount = 0;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireLeftCount = 0;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireLeftCount = 0;
        }
        else if (gameObject.name == "WireLeftPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            wireLeftCount = 0;
        }
    }
}
