using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BEE : MonoBehaviour
{
    [SerializeField]
    private GameObject OriginalHive;

    public GameObject[] flowers;

    public bool canGoToHive = false;

    // Start is called before the first frame update
    void Start()
    {
        CheckAnyFlower();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (canGoToHive)
            GoToHive();
    }

    public void SetSpawnedHive(GameObject OGHive)
    {

        OriginalHive = OGHive;
    }
    public void SetFlowerArray(GameObject[] _flowers)
    {
        flowers = _flowers;
    }

    public void CheckAnyFlower()
    {
        GameObject flower;

        int randomNum = UnityEngine.Random.Range(0, flowers.Length);

        flower = flowers[randomNum];
        transform.DOMove(flower.transform.position, 2f).OnComplete(() =>
        {
            if(flower.GetComponent<FLOWER>().takenectar() == true)
            {
                // go to hive
                canGoToHive = true;
            }
            else
            {
                CheckAnyFlower();
            }
        }).SetEase(Ease.Linear);
        
    }

    public void GoToHive()
    {
        canGoToHive = false;
        transform.DOMove(OriginalHive.transform.position, 1f).OnComplete(() =>
        {
            OriginalHive.GetComponent<BEEHIVE>().GiveNectar();
            CheckAnyFlower();
        }).SetEase(Ease.Linear);


    }

    //AVOID HITING OBJECT METHOD. INVISIBLE COLLIDER.

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BEEHIVE"))
        {
            collision.gameObject.GetComponent<BEEHIVE>().GiveNectar();
        }
    }

}
