using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//guidance from SpeedTutor

public class KeyRayCast : MonoBehaviour
{
    [SerializeField] private int raylength = 5;
    [SerializeField] private LayerMask LayerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private KeyController raycastedObject;
    [SerializeField] private KeyCode openDoorKey = KeyCode.Mouse0;

    [SerializeField] private Image crosshair = null;
    private bool isCrosshairActive;
    private bool doOnce;

    private string interactableTag = "InteractiveObject";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | LayerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out hit, raylength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    raycastedObject = hit.collider.gameObject.GetComponent<KeyController>();
                    CrosshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(openDoorKey))
                {
                    raycastedObject.ObjectInteraction();
                }
            }
        }

        else;
        {
            if (isCrosshairActive)
            {
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }

    void CrosshairChange(bool on)
    {
        if(on && !doOnce)
        {
            crosshair.color = Color.white;
        }
        else
        {
            crosshair.color = Color.black;
            isCrosshairActive = false;
        }
    }
} 
