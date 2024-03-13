using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


//Danielle Dennis Script Assistance (Tutoring)

public class ItemCollector : MonoBehaviour
{
    private int coins = 0;
    private int key = 0;

    //conect text to the coins
    [SerializeField] private TextMeshProUGUI coinsText;
    //conect text to the Key
    [SerializeField] private TextMeshProUGUI KeyText;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }

        if (collision.gameObject.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            key++;
            KeyText.text = "Key: " + coins;

            //if key collected open door bool or if loop? Maybe both?
        }
    }

}
