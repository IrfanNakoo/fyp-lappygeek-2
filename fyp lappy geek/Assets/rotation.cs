using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    private bool isRotating = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            float rotationX = Input.GetAxis("Mouse X");
            float rotationY = Input.GetAxis("Mouse Y");

            transform.Rotate(Vector3.up, -rotationX * Time.deltaTime * 100f, Space.World);
            transform.Rotate(Vector3.right, rotationY * Time.deltaTime * 100f, Space.World);
        }
    }
}
