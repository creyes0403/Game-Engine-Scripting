using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyCollision : MonoBehaviour
{
    public Material materialDamage;
    public Material materialNormal;

    private MeshRenderer mr;

    //This is for triggers

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.name == "Empty Enemy")
        //{
            mr.material = materialDamage;

            DOVirtual.DelayedCall(0.1F, () => //CREATE A FUNCTION IN THE FLY
            {
                mr.material = materialNormal;
            });
        //}
            
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    //This is for physics
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    public void Damage()
    {

    }
   
}
