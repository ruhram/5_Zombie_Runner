using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera FPScamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 20f;
    [SerializeField] float zoomOutSensivity = 2f;
    [SerializeField] float zoomInSensivity = .5f;

    bool zoomInToggle = false;
   

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomInToggle == false)
            {
                zoomInToggle = true;
                FPScamera.fieldOfView = zoomInFOV;
                fpsController.mouseLook.XSensitivity = zoomInSensivity;
                fpsController.mouseLook.YSensitivity = zoomInSensivity;

            }
            else
            {
                zoomInToggle = false;
                FPScamera.fieldOfView = zoomOutFOV;
                fpsController.mouseLook.XSensitivity = zoomOutSensivity;
                fpsController.mouseLook.YSensitivity = zoomOutSensivity;
            }
        }
    }

}
