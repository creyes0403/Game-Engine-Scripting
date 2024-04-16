using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSaver : MonoBehaviour
{
    public const string MONEY_ID = "Money";
    public const string LEVELS_COMPLETE_ID = "Levels Complete";
    public const string NAME_ID = "Name";

    public string playerName;
    public int level;
    public float dollars
    {
        get
        {
            return m_dollars;
        }
        private set
        {
            m_dollars = value;
            PlayerPrefs.SetFloat(MONEY_ID, dollars);

            Debug.Log(PlayerPrefs.GetFloat(MONEY_ID, 0));
        }
    }
    private float m_dollars;

    public SaveData SaveData;

    //field free range
    //properties limitations

    [ContextMenu("Save Data")]

    void SaveDataTest()
    {
        //storedata of the player/computer/documentation
        PlayerPrefs.SetInt(LEVELS_COMPLETE_ID,2);
        PlayerPrefs.SetString(NAME_ID, playerName);
        PlayerPrefs.SetFloat(MONEY_ID, dollars);

        PlayerPrefs.SetString("SaveData", JsonUtility.ToJson(SaveData));

        PlayerPrefs.Save();

    }

    [ContextMenu("Load Data")]
    void LoadData()
    {
        level = PlayerPrefs.GetInt(LEVELS_COMPLETE_ID, 1);
        playerName = PlayerPrefs.GetString(NAME_ID, "You have no name");
        m_dollars = PlayerPrefs.GetFloat(MONEY_ID, 0);
        //if decimals, add the f after the number like 12.5f

        SaveData = JsonUtility.FromJson<SaveData>(PlayerPrefs.GetString("SaveData"));
    }

    [ContextMenu("Add Dollar")]
    void AddDollar()
    {
        dollars++;
    }

}
