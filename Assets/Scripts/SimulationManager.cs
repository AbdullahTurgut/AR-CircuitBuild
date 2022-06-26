using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulationManager : MonoBehaviour
{
    //switch ve bulb emissionu için---------------------------------
    public GameObject bulbParentGameObj;
    public Renderer switchKeyObjRenderer;
    public Material[] switchOnOffMaterials;
    public AudioSource crushingFX;
    //----------------------------------------------------------------
    //switch btn için-------------------------------------------------
    private string switchBtnName = "switch key";
    private Transform state;
    private int switchBtncount;
    //----------------------------------------------------------------
    //Dugum Noklarýndaki count deðerlerini çekicez
    BatteryNegativePoint batteryNegative;
    BatteryPozitivePoint batteryPozitive;
    BulbLeftPoint bulbLeft;
    BulbRightPoint bulbRight;
    ReactorLeftPoint reactorLeft;
    ReactorRightPoint reactorRight;
    SwitchLeftPoint switchLeft;
    SwitchRightPoint switchRight;
    WireLeftPoint wireLeft;
    WireRightPoint wireRight;
    //--------------------------------------------------
    //Buttery ve Resistor Deðerleri için 
    BatteryVolt batteryVolt;
    ResistorOhm resistorOhm;
    //Etkileþim varsa Triggerlar oluþcak
    private bool batteryTrig;
    private bool bulbTrig;
    private bool reactorTrig;
    private bool switchTrig;
    private bool wireTrig;
    //------------------

    public bool arrowLeftBtnOn = false;
    public bool arrowRightBtnOn = false;
    public bool closeArrowBtns = false;

    //Requirement for arrow button
    public Transform leftReactorDugum;
    public Transform rightReactorDugum;
    public Transform batteryPozitiveDugum;
    public Transform batteryNegativeDugum;
    public GameObject multimeterLeft;
    public GameObject multimeterRight;
    public GameObject uiMultimeter;
    public GameObject mainButtons;
    public Text multimeterVoltText;
    public Text multimeterResistText;
    public Text multimeterAmperText;

    //---------------------

    public Text voltText;
    public Text resistText;
    public Text amperText;

    private float distancePozitive;
    private float distancePozitiveLeft;
    private float distanceNegative;
    private float distanceNegativeLeft;
    void Start()
    {
        switchOnOffMaterials[0] = switchKeyObjRenderer.GetComponent<Renderer>().material;
        //dugum noktalarý-----------------------
        batteryNegative = FindObjectOfType<BatteryNegativePoint>();
        batteryPozitive = FindObjectOfType<BatteryPozitivePoint>();
        bulbLeft = FindObjectOfType<BulbLeftPoint>();
        bulbRight = FindObjectOfType<BulbRightPoint>();
        reactorLeft = FindObjectOfType<ReactorLeftPoint>();
        reactorRight = FindObjectOfType<ReactorRightPoint>();
        switchLeft = FindObjectOfType<SwitchLeftPoint>();
        switchRight = FindObjectOfType<SwitchRightPoint>();
        wireLeft = FindObjectOfType<WireLeftPoint>();
        wireRight = FindObjectOfType<WireRightPoint>();
        //---------------------------------------------
        batteryVolt = FindObjectOfType<BatteryVolt>();
        resistorOhm = FindObjectOfType<ResistorOhm>();
    }



    private void Update()
    {
        batteryVolt = FindObjectOfType<BatteryVolt>();
        resistorOhm = FindObjectOfType<ResistorOhm>();
        SwitchOnOffEffectAnd();
        //Booleanlar--------------------------------
        if (batteryNegative.batteryNegativeCount > 0 && batteryPozitive.batteryPoizitveCount > 0)
        {
            batteryTrig = true;
        }
        else
        {
            batteryTrig = false;
        }
        if (bulbLeft.bulbLeftCount > 0 && bulbRight.bulbRightCount > 0)
        {
            bulbTrig = true;
        }
        else
        {
            bulbTrig = false;
        }
        if (reactorLeft.reactorLeftCount > 0 && reactorRight.reactorRightCount > 0)
        {
            reactorTrig = true;
        }
        else
        {
            reactorTrig = false;
        }
        if (switchLeft.switchLeftCount > 0 && switchRight.switchRightCount > 0)
        {
            switchTrig = true;
        }
        else
        {
            switchTrig = false;
        }
        if (wireLeft.wireLeftCount > 0 && wireRight.wireRightCount > 0)
        {
            wireTrig = true;
        }
        else
        {
            wireTrig = false;
        }
        //-------------------------------

        //Simulasyon için oluþacak durumlar-----------------
        if (batteryTrig && wireTrig && bulbTrig && reactorTrig)
        {
            voltText.text = "U = " + batteryVolt._batteryVolt.ToString() + " Volt";
            resistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
            amperText.text = "I = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
            bulbParentGameObj.transform.GetChild(3).gameObject.SetActive(false);
            bulbParentGameObj.transform.GetChild(4).gameObject.SetActive(true);
            if (arrowLeftBtnOn)
            {
                voltText.text = "";
                resistText.text = "";
                amperText.text = "";
                distancePozitive = Vector3.Distance(batteryPozitiveDugum.position, multimeterLeft.transform.position);
                distancePozitiveLeft = Vector3.Distance(batteryPozitiveDugum.position, multimeterRight.transform.position);
                distanceNegative = Vector3.Distance(batteryNegativeDugum.position, multimeterLeft.transform.position);
                distanceNegativeLeft = Vector3.Distance(batteryNegativeDugum.position, multimeterRight.transform.position);
                if (distancePozitive < distancePozitiveLeft || distanceNegative > distanceNegativeLeft)
                {
                    batteryVolt._batteryVolt *= 1;
                    multimeterVoltText.text = "U" + resistorOhm._resistorOhm.ToString() + "ohm = " + batteryVolt._batteryVolt.ToString() + " Volt";
                    multimeterResistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
                    multimeterAmperText.text = "I" + resistorOhm._resistorOhm.ToString() + "ohm = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
                }
            }
            if (arrowRightBtnOn)
            {
                voltText.text = "";
                resistText.text = "";
                amperText.text = "";
                distancePozitive = Vector3.Distance(batteryPozitiveDugum.position, multimeterRight.transform.position);
                distancePozitiveLeft = Vector3.Distance(batteryPozitiveDugum.position, multimeterLeft.transform.position);
                distanceNegative = Vector3.Distance(batteryNegativeDugum.position, multimeterRight.transform.position);
                distanceNegativeLeft = Vector3.Distance(batteryNegativeDugum.position, multimeterLeft.transform.position);
                if (distancePozitive > distancePozitiveLeft || distanceNegative < distanceNegativeLeft)
                {
                    batteryVolt._batteryVolt *= -1;
                    multimeterVoltText.text = "U" + resistorOhm._resistorOhm.ToString() + "ohm = " + batteryVolt._batteryVolt.ToString() + " Volt";
                    multimeterResistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
                    multimeterAmperText.text = "I" + resistorOhm._resistorOhm.ToString() + "ohm = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
                }
            }
            if (closeArrowBtns)
            {
                closeArrowBtns = false;
                Mathf.Abs(batteryVolt._batteryVolt);
                multimeterVoltText.text = "";
                multimeterResistText.text = "";
                multimeterAmperText.text = "";
            }
        }
        else if (batteryTrig && wireTrig && reactorTrig && switchTrig)
        {
            if (switchBtncount == 1)
            {
                voltText.text = "U = " + batteryVolt._batteryVolt.ToString() + " Volt";
                resistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
                amperText.text = "I = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
                switchKeyObjRenderer.material = switchOnOffMaterials[1];
                if (arrowLeftBtnOn)
                {
                    voltText.text = "";
                    resistText.text = "";
                    amperText.text = "";
                    distancePozitive = Vector3.Distance(batteryPozitiveDugum.position, multimeterLeft.transform.position);
                    distancePozitiveLeft = Vector3.Distance(batteryPozitiveDugum.position, multimeterRight.transform.position);
                    distanceNegative = Vector3.Distance(batteryNegativeDugum.position, multimeterLeft.transform.position);
                    distanceNegativeLeft = Vector3.Distance(batteryNegativeDugum.position, multimeterRight.transform.position);
                    if (distancePozitive < distancePozitiveLeft || distanceNegative > distanceNegativeLeft)
                    {
                        batteryVolt._batteryVolt *= 1;
                        multimeterVoltText.text = "U" + resistorOhm._resistorOhm.ToString() + "ohm = " + batteryVolt._batteryVolt.ToString() + " Volt";
                        multimeterResistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
                        multimeterAmperText.text = "I" + resistorOhm._resistorOhm.ToString() + "ohm = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
                    }
                }
                if (arrowRightBtnOn)
                {
                    voltText.text = "";
                    resistText.text = "";
                    amperText.text = "";
                    distancePozitive = Vector3.Distance(batteryPozitiveDugum.position, multimeterRight.transform.position);
                    distancePozitiveLeft = Vector3.Distance(batteryPozitiveDugum.position, multimeterLeft.transform.position);
                    distanceNegative = Vector3.Distance(batteryNegativeDugum.position, multimeterRight.transform.position);
                    distanceNegativeLeft = Vector3.Distance(batteryNegativeDugum.position, multimeterLeft.transform.position);
                    if (distancePozitive > distancePozitiveLeft || distanceNegative < distanceNegativeLeft)
                    {
                        batteryVolt._batteryVolt *= -1;
                        multimeterVoltText.text = "U" + resistorOhm._resistorOhm.ToString() + "ohm = " + batteryVolt._batteryVolt.ToString() + " Volt";
                        multimeterResistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
                        multimeterAmperText.text = "I" + resistorOhm._resistorOhm.ToString() + "ohm = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
                    }
                }
                if (closeArrowBtns)
                {
                    closeArrowBtns = false;
                    Mathf.Abs(batteryVolt._batteryVolt);
                    multimeterVoltText.text = "";
                    multimeterResistText.text = "";
                    multimeterAmperText.text = "";
                }

            }
            else
            {
                voltText.text = "";
                resistText.text = "";
                amperText.text = "";
                multimeterVoltText.text = "";
                multimeterResistText.text = "";
                multimeterAmperText.text = "";
                CloseArrowButton();
                switchKeyObjRenderer.material = switchOnOffMaterials[0];
            }
        }
        else if (bulbTrig && wireTrig && reactorTrig && switchTrig)
        {
            voltText.fontSize = 15;
            voltText.text = "Please connect a power supply to your circuit!";
            bulbParentGameObj.transform.GetChild(3).gameObject.SetActive(true);
            bulbParentGameObj.transform.GetChild(4).gameObject.SetActive(false);
            switchKeyObjRenderer.material = switchOnOffMaterials[0];
        }
        else if (batteryTrig && bulbTrig && wireTrig && switchTrig)
        {
            if (switchBtncount == 1)
            {
                voltText.text = "U = " + batteryVolt._batteryVolt.ToString() + " Volt";
                resistText.fontSize = 15;
                resistText.text = "Warning !! Connect a resistor to the circuit. Circuit elements will be damaged.";
                amperText.text = "I = " + batteryVolt._batteryVolt.ToString() + " Amper";
                bulbParentGameObj.transform.GetChild(3).gameObject.SetActive(false);
                bulbParentGameObj.transform.GetChild(4).gameObject.SetActive(true);
                switchKeyObjRenderer.material = switchOnOffMaterials[1];
                if(batteryVolt._batteryVolt == 30f)
                {
                    bulbParentGameObj.transform.GetChild(3).gameObject.SetActive(true);
                    bulbParentGameObj.transform.GetChild(4).gameObject.SetActive(false);
                    switchKeyObjRenderer.material = switchOnOffMaterials[0];
                    voltText.text = "";
                    resistText.text = "SWITCH AND BULB GOT DAMAGED BY HIGH VOLTAGE";
                    amperText.text = "";
                }
            }
            else
            {
                resistText.fontSize = 25;
                voltText.text = "";
                resistText.text = "";
                amperText.text = "";
                bulbParentGameObj.transform.GetChild(3).gameObject.SetActive(true);
                bulbParentGameObj.transform.GetChild(4).gameObject.SetActive(false);
                switchKeyObjRenderer.material = switchOnOffMaterials[0];
            }
        }
        else if (batteryTrig && bulbTrig && reactorTrig && switchTrig)
        {
            if (switchBtncount == 1)
            {
                voltText.text = "U = " + batteryVolt._batteryVolt.ToString() + " Volt";
                resistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
                amperText.text = "I = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
                bulbParentGameObj.transform.GetChild(3).gameObject.SetActive(false);
                bulbParentGameObj.transform.GetChild(4).gameObject.SetActive(true);
                switchKeyObjRenderer.material = switchOnOffMaterials[1];
                if (arrowLeftBtnOn)
                {
                    voltText.text = "";
                    resistText.text = "";
                    amperText.text = "";
                    distancePozitive = Vector3.Distance(batteryPozitiveDugum.position, multimeterLeft.transform.position);
                    distancePozitiveLeft = Vector3.Distance(batteryPozitiveDugum.position, multimeterRight.transform.position);
                    distanceNegative = Vector3.Distance(batteryNegativeDugum.position, multimeterLeft.transform.position);
                    distanceNegativeLeft = Vector3.Distance(batteryNegativeDugum.position, multimeterRight.transform.position);
                    if (distancePozitive < distancePozitiveLeft || distanceNegative > distanceNegativeLeft)
                    {
                        batteryVolt._batteryVolt *= 1;
                        multimeterVoltText.text = "U" + resistorOhm._resistorOhm.ToString() + "ohm = " + batteryVolt._batteryVolt.ToString() + " Volt";
                        multimeterResistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
                        multimeterAmperText.text = "I" + resistorOhm._resistorOhm.ToString() + "ohm = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
                    }
                }
                if (arrowRightBtnOn)
                {
                    voltText.text = "";
                    resistText.text = "";
                    amperText.text = "";
                    distancePozitive = Vector3.Distance(batteryPozitiveDugum.position, multimeterRight.transform.position);
                    distancePozitiveLeft = Vector3.Distance(batteryPozitiveDugum.position, multimeterLeft.transform.position);
                    distanceNegative = Vector3.Distance(batteryNegativeDugum.position, multimeterRight.transform.position);
                    distanceNegativeLeft = Vector3.Distance(batteryNegativeDugum.position, multimeterLeft.transform.position);
                    if (distancePozitive > distancePozitiveLeft || distanceNegative < distanceNegativeLeft)
                    {
                        batteryVolt._batteryVolt *= -1;
                        multimeterVoltText.text = "U" + resistorOhm._resistorOhm.ToString() + "ohm = " + batteryVolt._batteryVolt.ToString() + " Volt";
                        multimeterResistText.text = "R = " + resistorOhm._resistorOhm.ToString() + " Ohm";
                        multimeterAmperText.text = "I" + resistorOhm._resistorOhm.ToString() + "ohm = " + (batteryVolt._batteryVolt / resistorOhm._resistorOhm).ToString() + " Amper";
                    }
                }
                if (closeArrowBtns)
                {
                    closeArrowBtns = false;
                    Mathf.Abs(batteryVolt._batteryVolt);
                    multimeterVoltText.text = "";
                    multimeterResistText.text = "";
                    multimeterAmperText.text = "";
                }
            }
            else
            {
                voltText.text = "";
                resistText.text = "";
                amperText.text = "";
                multimeterVoltText.text = "";
                multimeterResistText.text = "";
                multimeterAmperText.text = "";
                CloseArrowButton();
                bulbParentGameObj.transform.GetChild(3).gameObject.SetActive(true);
                bulbParentGameObj.transform.GetChild(4).gameObject.SetActive(false);
                switchKeyObjRenderer.material = switchOnOffMaterials[0];
            }

        }
        else
        {
            resistText.fontSize = 25;
            voltText.fontSize = 25;
            voltText.text = "";
            resistText.text = "";
            amperText.text = "";
            bulbParentGameObj.transform.GetChild(3).gameObject.SetActive(true);
            bulbParentGameObj.transform.GetChild(4).gameObject.SetActive(false);
            switchKeyObjRenderer.material = switchOnOffMaterials[0];
        }
        //-----------------------------

    }

    public void SimulationQuit()
    {
        Application.Quit();
    }

    public void SwitchTargetLost()
    {
        switchTrig = false;
    }
    public void BatteryTargetLost()
    {
        batteryTrig = false;
    }
    public void BulbTargetLost()
    {
        bulbTrig = false;
    }
    public void ReactorTargetLost()
    {
        reactorTrig = false;
    }
    public void WireTargetLost()
    {
        wireTrig = false;
    }

    //Switch Btn
    public void SwitchOnOffEffectAnd()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                if (switchBtnName == Hit.collider.gameObject.name)
                {
                    state = Hit.transform;
                    if (switchBtncount == 0)
                    {
                        state.Rotate(new Vector3(-30.7f, 0, 0));
                        switchBtncount = 1;
                    }
                    else
                    {
                        state.Rotate(new Vector3(30.7f, 0, 0));
                        switchBtncount = 0;
                    }
                }
            }
        }
    }
   
    public void ArrowButtonLeft()
    {
        arrowLeftBtnOn = true;
        multimeterLeft.transform.GetChild(0).gameObject.SetActive(true);
        multimeterRight.transform.GetChild(1).gameObject.SetActive(true);
        uiMultimeter.gameObject.SetActive(true);
    }
    public void ArrowButtonRight()
    {
        arrowRightBtnOn = true;
        multimeterRight.transform.GetChild(0).gameObject.SetActive(true);
        multimeterLeft.transform.GetChild(1).gameObject.SetActive(true);
        uiMultimeter.gameObject.SetActive(true);
    }

    public void CloseArrowButton()
    {
        if (arrowLeftBtnOn)
        {
            arrowLeftBtnOn = false;
            multimeterLeft.transform.GetChild(0).gameObject.SetActive(false);
            multimeterRight.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (arrowRightBtnOn)
        {
            arrowRightBtnOn = false;
            multimeterRight.transform.GetChild(0).gameObject.SetActive(false);
            multimeterLeft.transform.GetChild(1).gameObject.SetActive(false);
        }
        closeArrowBtns = true;
        uiMultimeter.gameObject.SetActive(false);
        mainButtons.SetActive(true);
    }
}