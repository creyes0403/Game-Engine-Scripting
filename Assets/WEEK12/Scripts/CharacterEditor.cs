using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

namespace CharacterEditor
{
    //Sally once again came to the rescue :)
    public class CharacterEditor : MonoBehaviour
    {
        public UnityEvent Buttons;

        [SerializeField] Button nextMaterial;
        [SerializeField] Button nextBodyPart;
        [SerializeField] Button loadGame;

        [SerializeField] Character character;

        int id;
        BodyTypes bodyType = BodyTypes.Head;

        private void Awake()
        {
            Buttons = new UnityEvent();

            Buttons.AddListener(NextBodyPart);
            Buttons.AddListener(NextMaterial);
            Buttons.AddListener(LoadGame);
            //TODO: Setup some button listeners to call the NextMaterial, NextBodyPart, and LoadGame functions
        }

        public void NextMaterial()
        {
            id++;

            if (id >= 3)
            {
                id = 0;
            }
            //TODO: Add 1 to the value of id and if it is 3 or more then reset back to 0

            switch (bodyType)
            {
                case BodyTypes.Arm:
                    PlayerPrefs.SetInt("Armpreference", id);
                    break;

                case BodyTypes.Leg:
                    PlayerPrefs.SetInt("Legpreference", id);
                    break;

                case BodyTypes.Head:
                    PlayerPrefs.SetInt("Headpreference", id);
                    break;

                case BodyTypes.Body:
                    PlayerPrefs.SetInt("Bodypreference", id);
                    break;
            }

            //TODO: Make a switch case for each BodyType and save the value of id to the correct PlayerPref

            character.Load();

            //TODO: Tell the character to load to get the updated body piece
        }

        public void NextBodyPart()
        {
            switch (bodyType)
            {
                case BodyTypes.Arm:
                    bodyType = BodyTypes.Leg;

                    break;

                case BodyTypes.Leg:
                    bodyType = BodyTypes.Head;

                    break;

                case BodyTypes.Head:
                    bodyType = BodyTypes.Body;

                    break;

                case BodyTypes.Body:
                    bodyType = BodyTypes.Arm;

                    break;

            }
            //TODO: Setup a switch case that will go through the different body types
            //      ie if the current type is Head and we click next then set it to Body

            switch (bodyType)
            {
                case BodyTypes.Arm:
                    id = PlayerPrefs.GetInt("Armpreference");

                    break;

                case BodyTypes.Leg:
                    id = PlayerPrefs.GetInt("Legpreference");

                    break;

                case BodyTypes.Head:
                    id = PlayerPrefs.GetInt("Headpreference");

                    break;

                case BodyTypes.Body:
                    id = PlayerPrefs.GetInt("Bodypreference");

                    break;

            }
            //TODO: Then setup another switch case that will get the current saved value
            //      from the player prefs for the current body type and set it to id
        }

        public void LoadGame()
        {
            SceneManager.LoadScene("loadleveldemo");
        }
    }
}