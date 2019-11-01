using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsDataBase : MonoBehaviour
{
    [SerializeField] private Animal[] animalsDataBase;
    private int adCounter=0;

    private void Start()
    {
        UIController.instance.ChaneObjectMainImg(animalsDataBase[0].animalSprite, animalsDataBase[0].name);
    }

    public void PlayAudio(int objectIndex)
    {
        AudioController.instance.PlayClip(animalsDataBase[objectIndex].animalClip);
        UIController.instance.ChaneObjectMainImg(animalsDataBase[objectIndex].animalSprite, animalsDataBase[objectIndex].name);
        adCounter++;

        if(adCounter >= 5)
        {
            if (AdsController.instance.ShowIntertitial())
            {
                adCounter = 0;
            }
        }
    }
}

[System.Serializable]
public struct Animal
{
    public string name;
    public Sprite animalSprite;
    public AudioClip animalClip;
}
