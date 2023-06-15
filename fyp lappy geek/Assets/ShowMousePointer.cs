using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMousePointer : MonoBehaviour
{
    public Camera targetCamera;
    
    void Start()
    {
        if (targetCamera != null)
        {
            targetCamera.GetComponent<Camera>().cursor.visible = true;
            targetCamera.GetComponent<Camera>().cursor.lockstate = cursorLockMode.None;
        }

        else
        {
            Debug.LogWarning("No target camera assigned to show mouse pointer");
        }
    }
}
