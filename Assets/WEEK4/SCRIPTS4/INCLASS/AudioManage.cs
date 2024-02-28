using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    private static AudioManage instance;

    [SerializeField] GameObject soundEffectPrefab;

    [SerializeField]AudioClip attack;
    [SerializeField] AudioClip damage;
    [SerializeField] AudioClip music;

    private AudioSource audio;

    //ENUM = Assign words to numbers

    public enum SoundType
    {
        //NONE = -1,
        ATTACK = 0,
        DAMAGE = 1,
        MUSIC = 3
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public static void PlaySound(SoundType s)
    {

        instance.privPlaySound(s);
    }

    private void privPlaySound(SoundType s)
    {
        audio.clip = attack;

        /*switch(s)
        {
            case SoundType.ATTACK: audio.PlayOneShot(attack); break;
            case SoundType.DAMAGE: audio.PlayOneShot(damage); break;
            case SoundType.MUSIC: audio.PlayOneShot(music); break;

        }*/

        /*switch (s)
        {
            case SoundType.ATTACK: audio.clip = attack; break;
            case SoundType.DAMAGE: audio.clip = damage; break;
            case SoundType.MUSIC: audio.clip = music; break;

        }*/

        AudioClip clip = null;

        GameObject soundEffectObject = Instantiate(soundEffectPrefab);
        SoundEffect soundEffect = soundEffectObject.GetComponent<SoundEffect>();
        soundEffect.Initialized(clip);
        soundEffect.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) privPlaySound(SoundType.MUSIC);
        if (Input.GetKeyDown(KeyCode.S)) privPlaySound(SoundType.ATTACK);
        if (Input.GetKeyDown(KeyCode.A)) privPlaySound(SoundType.MUSIC);

    }
}
