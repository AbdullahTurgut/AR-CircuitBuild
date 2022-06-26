using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbRightPoint : MonoBehaviour
{
    public int bulbRightCount;
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
        if (gameObject.name == "BulbRightPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbRightCount = 1;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbRightCount = 1;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbRightCount = 1;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbRightCount = 1;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbRightCount = 1;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbRightCount = 1;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbRightCount = 1;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            bulbRightCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "BulbRightPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbRightCount = 0;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbRightCount = 0;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbRightCount = 0;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbRightCount = 0;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("SwitchLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbRightCount = 0;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("SwitchRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbRightCount = 0;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbRightCount = 0;
        }
        else if (gameObject.name == "BulbRightPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            bulbRightCount = 0;
        }
    }
}
