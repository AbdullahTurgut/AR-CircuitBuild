using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLeftPoint : MonoBehaviour
{
    public int switchLeftCount;
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
        if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchLeftCount = 1;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchLeftCount = 1;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchLeftCount = 1;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchLeftCount = 1;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchLeftCount = 1;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchLeftCount = 1;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchLeftCount = 1;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchLeftCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchLeftCount = 0;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchLeftCount = 0;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchLeftCount = 0;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchLeftCount = 0;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchLeftCount = 0;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchLeftCount = 0;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchLeftCount = 0;
        }
        else if (gameObject.name == "SwitchLeftPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchLeftCount = 0;
        }
    }
}
