using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRightPoint : MonoBehaviour
{
    public int switchRightCount;
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
        if (gameObject.name == "SwitchRightPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchRightCount = 1;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchRightCount = 1;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchRightCount = 1;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchRightCount = 1;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchRightCount = 1;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchRightCount = 1;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchRightCount = 1;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            switchRightCount = 1;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "SwitchRightPoint" && other.CompareTag("BatteryNegative"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchRightCount = 0;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("BatteryPozitive"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchRightCount = 0;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("ReactorLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchRightCount = 0;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("ReactorRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchRightCount = 0;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("BulbLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchRightCount = 0;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("BulbRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchRightCount = 0;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("WireLeft"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchRightCount = 0;
        }
        else if (gameObject.name == "SwitchRightPoint" && other.CompareTag("WireRight"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            switchRightCount = 0;
        }
    }
}
