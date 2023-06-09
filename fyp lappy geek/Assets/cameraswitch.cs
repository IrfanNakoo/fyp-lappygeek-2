using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    private Camera activeCamera;

    private void Start()
    {
        // Set camera1 as the initially active camera
        ActivateCamera(camera1);
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            SwitchCamera();
        }
    }

    //private void Update()
    //{
    //    if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
    //    {
    //        SwitchCamera();
    //    }
    //}

    private void SwitchCamera()
    {
        if (activeCamera == camera1)
        {
            // Switch to camera2
            ActivateCamera(camera2);
        }
        else
        {
            // Switch to camera1
            ActivateCamera(camera1);
        }
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ForceSwitch();
        }
    }

    private void ForceSwitch()
    {
        if (activeCamera == camera2)
        {
            // Switch to camera1
            ActivateCamera(camera1);
        }
        else
        {
            // Switch to camera2
            ;
        }
    }



    private void ActivateCamera(Camera cameraToActivate)
    {
        if (activeCamera != null)
        {
            // Disable the previously active camera
            activeCamera.enabled = false;
        }

        // Enable the new camera
        activeCamera = cameraToActivate;
        activeCamera.enabled = true;
    }
}
