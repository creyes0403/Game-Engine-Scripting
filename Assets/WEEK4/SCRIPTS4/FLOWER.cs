using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLOWER : MonoBehaviour
{
    float nectarrate = 200;
    float nectarcounting = 0;
    bool nectaramount = true;

    SpriteRenderer spriteRenderer; 

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nectarcounting);
        if (nectaramount == true)
        {
            spriteRenderer.color = Color.white;
            
        }

        else 
        {
            spriteRenderer.color = Color.red;
            nectarcounting += 1;
        }

        if (nectarcounting == nectarrate)
        {
            Debug.Log("flower");
            spriteRenderer.color = Color.white;
            nectaramount = true;
            nectarcounting = 0;

        }
        
    }

    public bool nectaravilable()
    {
        if (nectaramount == true)
        {
            
            return true;
        }

        else
        {
            
            return false;
        }
    }

    public bool takenectar()
    {
        if (nectaravilable())
        { 
            
            nectaramount = false;

            return true;
        }
         else
        {
            return false;
        }
    }
}
