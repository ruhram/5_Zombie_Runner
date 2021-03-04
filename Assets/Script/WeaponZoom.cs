using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera FPScamera;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 20f;

    bool zoomInToggle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomInToggle == false)
            {
                zoomInToggle = true;
                FPScamera.fieldOfView = zoomInFOV;
            }
            else
            {
                zoomInToggle = false;
                FPScamera.fieldOfView = zoomOutFOV;
            }
        }
    }

}
