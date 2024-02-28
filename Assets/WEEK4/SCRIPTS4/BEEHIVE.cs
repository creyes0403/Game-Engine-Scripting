using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEEHIVE : MonoBehaviour
{
    float honeyproductionrate = 5;
    float honeycounting = 0;

    int BeesPopulation = 0;

    int Nector;
    int Honey;

    [SerializeField]
    GameObject BeePrefab;

    public GameObject[] flowers;

    // Start is called before the first frame update
    void Start()
    {
        CreateBee();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void FixedUpdate()
    {
        honeycount(); 
    }
    
    void CreateBee() {

        for (int i = 0; i < BeesPopulation; i++)
        {
            //creates a temp GameObject in memory that the spawned in objects takes.
            GameObject tempbee = Instantiate(BeePrefab, this.transform);
            tempbee.GetComponent<BEE>().SetFlowerArray(flowers);
            tempbee.GetComponent<BEE>().SetSpawnedHive(this.gameObject);
        }
    }

    void honeycount()
    {
        if(Nector != 0)
        {
            honeycounting++;
            if(honeycounting >= honeyproductionrate)
            {
                Honey++;
                Nector--;
                honeycounting = 0;
            }
        }
        
    }

    public void GiveNectar()
    {
        Nector++;
    }
    
}
