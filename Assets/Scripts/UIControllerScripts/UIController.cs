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

    [Header("Scrolling buttons Repfrences")]
    [SerializeField] private Image[] typesBtnsImgs;
    [SerializeField] private Sprite[] typesBtnsNotSelectedSprites;
    [SerializeField] private Sprite[] typesBtnsSelectedSprites;

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
                typesBtnsImgs[i].sprite = typesBtnsSelectedSprites[i];
            }
            else
            {
                panels[i].SetActive(false);
                typesBtnsImgs[i].sprite = typesBtnsNotSelectedSprites[i];
            }
        }
    }

    public void ChaneObjectMainImg(Sprite sprite, string name)
    {
        objectMainImg.sprite = sprite;
        objectName.text = char.ToUpper(name[0]).ToString();
        for (int i = 1; i < name.Length; i++)
        {
            objectName.text += name[i];
        }
    }
}
