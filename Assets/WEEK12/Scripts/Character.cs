using UnityEngine;

namespace CharacterEditor
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private MeshRenderer m_Head;
        [SerializeField] private MeshRenderer m_Body;
        [SerializeField] private MeshRenderer m_ArmR;
        [SerializeField] private MeshRenderer m_ArmL;
        [SerializeField] private MeshRenderer m_LegR;
        [SerializeField] private MeshRenderer m_LegL;

        private void Start()
        {
            Load();
        }

        public void Load()
        {
            m_Head.material= MaterialManager.Get(BodyTypes.Head,PlayerPrefs.GetInt("Headpreference"));
            m_Body.material = MaterialManager.Get(BodyTypes.Body, PlayerPrefs.GetInt("Bodypreference"));
            m_ArmR.material = MaterialManager.Get(BodyTypes.Arm, PlayerPrefs.GetInt("Armpreference"));
            m_ArmL.material = MaterialManager.Get(BodyTypes.Arm, PlayerPrefs.GetInt("Armpreference"));
            m_LegR.material = MaterialManager.Get(BodyTypes.Leg, PlayerPrefs.GetInt("Legpreference"));
            m_LegL.material = MaterialManager.Get(BodyTypes.Leg, PlayerPrefs.GetInt("Legpreference"));

            //Load materials from the MaterialManager and pass in the id pulled from each PlayerPref here
        }
    }
}