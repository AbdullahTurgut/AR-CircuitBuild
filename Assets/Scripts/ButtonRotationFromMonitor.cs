using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotationFromMonitor : MonoBehaviour
{
    Transform camTransform;
    public Transform uiLeft;
    public Transform uiRight;
    public Transform uiMultimeter;


    // Start is called before the first frame update
    void Start()
    {
        camTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        LookRotationSetting(uiLeft);
        LookRotationSetting(uiRight);
        LookRotationSetting(uiMultimeter);
    }

    private void LookRotationSetting(Transform ui)
    {
        Vector3 lookDirection = (ui.position - camTransform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(lookDirection);
        ui.rotation = lookRotation;
    }
}
