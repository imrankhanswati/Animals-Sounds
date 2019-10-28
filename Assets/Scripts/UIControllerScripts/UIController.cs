using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    [Header("Audio controle panel")]
    [SerializeField] private Slider volumeSlider;

    [Space(5)]
    [SerializeField] private Image repeatBtnImg;
    [SerializeField] private Sprite repeatSprite;
    [SerializeField] private Sprite noRepeatSprite;

    [Header("Panels reprences")]
    [SerializeField] private Image objectMainImg;
    [SerializeField] private Text objectName;
    [SerializeField] private GameObject[] panels;

    private void Awake()
    {
        instance = this;
        EnablePanel(0);
    }

    public void ChangeRepeateBtnStatus(bool isRepeat)
    {
        if (isRepeat)
        {
            repeatBtnImg.sprite = repeatSprite;
        }
        else
        {
            repeatBtnImg.sprite = noRepeatSprite;
        }
    }

    public void EnablePanel(int panelIndex)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == panelIndex)
            {
                panels[i].SetActive(true);
            }
            else
            {
                panels[i].SetActive(false);
            }
        }
    }

    public void ChaneObjectMainImg(Sprite sprite,string name)
    {
        objectMainImg.sprite = sprite;
        objectName.text = name;
    }
}
