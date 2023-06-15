using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavitatejack : MonoBehaviour
{
    public Transform cameraTransform;

    void Update()
    {
        Vector3 directionToCamera = cameraTransform.position - transform.position;

        transform.rotation = Quaternion.LookRotation(-directionToCamera, Vector3.up);
    }
}
