using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchNextAndPrev : MonoBehaviour
{
    [SerializeField] private GameObject[] resistors;
    [SerializeField] private GameObject[] batteries;
    public Text whichResist;
    public Text whichBattery;

    int index;
    int batteryIndex;
    void Start()
    {
        index = 0;
        batteryIndex = 0;
    }


    void Update()
    {
        if (index >= 2)
        {
            index = 2;
        }

        if (index < 0)
        {
            index = 0;
        }

        if (index == 0)
        {
            resistors[0].gameObject.SetActive(true);
            whichResist.text = "Direnç : " + resistors[0].gameObject.GetComponent<ResistorOhm>()._resistorOhm.ToString() + "R";
        }


        if (batteryIndex >= 1)
        {
            batteryIndex = 1;
        }

        if (batteryIndex < 0)
        {
            batteryIndex = 0;
        }

        if (batteryIndex == 0)
        {
            batteries[0].gameObject.SetActive(true);
            whichBattery.text = "Voltaj : " + batteries[0].gameObject.GetComponent<BatteryVolt>()._batteryVolt.ToString() + "V";
        }

    }

    public void Next()
    {
        index += 1;
        for (int i = 0; i < resistors.Length; i++)
        {
            resistors[i].gameObject.SetActive(false);
            resistors[index].gameObject.SetActive(true);
            whichResist.text = "Direnç : " + resistors[index].gameObject.GetComponent<ResistorOhm>()._resistorOhm.ToString() + "R";
        }

    }

    public void Previous()
    {
        index -= 1;
        for (int i = 0; i < resistors.Length; i++)
        {
            resistors[i].gameObject.SetActive(false);
            resistors[index].gameObject.SetActive(true);
            whichResist.text = "Direnç : " + resistors[index].gameObject.GetComponent<ResistorOhm>()._resistorOhm.ToString() + "R";
        }

    }



    public void NextBattery()
    {
        batteryIndex += 1;
        for (int i = 0; i < batteries.Length; i++)
        {
            batteries[i].gameObject.SetActive(false);
            batteries[batteryIndex].gameObject.SetActive(true);
            whichBattery.text = "Voltaj : " + batteries[batteryIndex].gameObject.GetComponent<BatteryVolt>()._batteryVolt.ToString() + "V";
        }

    }

    public void PreviousBattery()
    {
        batteryIndex -= 1;
        for (int i = 0; i < batteries.Length; i++)
        {
            batteries[i].gameObject.SetActive(false);
            batteries[batteryIndex].gameObject.SetActive(true);
            whichBattery.text = "Voltaj : " + batteries[batteryIndex].gameObject.GetComponent<BatteryVolt>()._batteryVolt.ToString() + "V";
        }

    }
}