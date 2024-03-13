using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] private bool MazeDoor = false;
    [SerializeField] private bool Mazekey = false;

    [SerializeField] private KeyInventory keyInventory = null;

    private KeyDoorController doorObject;

    private void Start()
    {
        if (MazeDoor)
        {
            doorObject = GetComponent<KeyDoorController>();
        }
            
    }

    public void ObjectInteraction()
    {
        if (MazeDoor)
        {
            doorObject.PlayAnimation();
        }

        else if (Mazekey)
        {
            keyInventory.hasKey = true;
            gameObject.SetActive(false);
        }
    }

        
    
}
