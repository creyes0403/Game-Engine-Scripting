using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coins");
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.CoinsCollected();
            gameObject.SetActive(false);
        }
    }

    public void Start()
    {

        Player.GetComponent<Player>().RestartEvent.AddListener(Restart);

    }

    public void Restart()
    {
        gameObject.SetActive(true);
        Debug.Log("HAHA");
    }
}
