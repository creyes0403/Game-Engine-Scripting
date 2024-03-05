using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] GameObject door;

    Vector3 origin;
    Vector3 target;

    bool isOpening;
    float alpha;
    float OpenSpeedModifier;

    private void Awake()
    {
        origin = transform.position;
        target = origin + (Vector3.up * 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        door.transform.position = transform.position + (Vector3.up * 10);
    }

    private void OnTriggerExit(Collider other)
    {
        door.transform.position = origin;
    }

    // Update is called once per frame
    void Update()
    {
        alpha += isOpening ? Time.deltaTime * OpenSpeedModifier : -Time.deltaTime * OpenSpeedModifier;
        alpha = Mathf.Clamp01(alpha);

        door.transform.position = Vector3.Lerp(origin, target, alpha);
    }
    //is adding an a and b value + an alfa value from 0start to 1end. A linear curve.
}
