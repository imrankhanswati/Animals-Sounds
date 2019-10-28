using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;

    private AudioSource audioSource;
    private bool repeat = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        //UIController.instance.ChangeRepeateBtnStatus(repeat);
    }

    public void PlayClip(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    public void ChangePlayBackMode()
    {
        repeat = !repeat;
        audioSource.loop = repeat;

        UIController.instance.ChangeRepeateBtnStatus(repeat);
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
