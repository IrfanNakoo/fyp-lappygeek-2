using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickndrop : MonoBehaviour
{
    public Transform playerCameraTransform;
    public Transform objectGrabPointTransform;
    public LayerMask pickUpLayerMask;

   private ObjectGrabable objectGrabable;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //(Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrabable == null)
            {
                float pickUpDistance = 20f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLayerMask))
                {
                    if (raycastHit.transform.TryGetComponent(out objectGrabable))
                    {
                        objectGrabable.Grab(objectGrabPointTransform);
                    }
                }
            }
            else
            {
                objectGrabable.Drop();
                objectGrabable = null;
            }
        }
    }
}
