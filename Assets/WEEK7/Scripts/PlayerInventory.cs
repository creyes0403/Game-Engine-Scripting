using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//Ketra Games Assitance

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] GameObject Player;

    public int numberofcoins { get; private set; }

    public UnityEvent<PlayerInventory> OnCoinCollected;

    public void CoinsCollected()
    {
        numberofcoins++;
        OnCoinCollected.Invoke(this);
    }

    public void Start()
    {

        Player.GetComponent<Player>().RestartEvent.AddListener(Restart);

    }

    public void Restart()
    {
        numberofcoins = 0;

    }
}
