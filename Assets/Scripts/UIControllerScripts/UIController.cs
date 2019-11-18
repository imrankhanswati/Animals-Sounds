using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    [Header("Audio controle panel")]
    [SerializeField] private Slider volumeSlider;

    [Space(5)]
    [SerializeField] private Image repeatBtnImg;
    [SerializeField] private Sprite repeatSprite;
    [SerializeField] private Sprite noRepeatSprite;

    [Header("Panels reprences"), Space(10)]
    [SerializeField] private Image objectMainImg;
    [SerializeField] private Text objectName;
    [SerializeField] private GameObject[] panels;

    [Header("Scrolling buttons Repfrences"), Space(10)]
    [SerializeField] private Image[] typesBtnsImgs;
    [SerializeField] private Sprite[] typesBtnsNotSelectedSprites;
    [SerializeField] private Sprite[] typesBtnsSelectedSprites;

    [Header("UI Panels refrences"), Space(10)]
    [SerializeField] private Image panelsBGImg;
    [SerializeField] private RectTransform infoPanle;
    [SerializeField] private RectTransform rateUsPanel;
    [SerializeField] private RectTransform privacyPanel;
    [SerializeField] private RectTransform quitPanle;
    [SerializeField] private RectTransform sharePanel;
    [SerializeField] private RectTransform giftPanel;

    [Header("Animations Settings"), Space(10)]
    [SerializeField] private float windowsOpenAnimationDuration;
    [SerializeField] private float windowsCloseAnimationDuration;
    [SerializeField] private Ease windowsOpenEaseType;
    [SerializeField] private Ease windowsCloseEaseType;

    [Header("Socailization Controles"), Space(10)]
    [SerializeField] private string AppNameString;
    [SerializeField] private string appDescriptionString;
    [SerializeField] private string rateUSLink;
    [SerializeField] private string shareLink;
    [SerializeField] private string privacyLink;

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

    //-------------------------------------------UI Panels Controles--------------------------------------------------------------//
    public void EDInfoPanel(bool status)
    {
        if (status)
        {
            infoPanle.gameObject.SetActive(true);
            EDPanelsImg(true);
            infoPanle.DOScale(new Vector3(1, 1, 1), windowsOpenAnimationDuration).SetEase(windowsOpenEaseType);
        }
        else
        {
            infoPanle.DOScale(new Vector3(0, 0, 0), windowsCloseAnimationDuration).SetEase(windowsCloseEaseType).OnComplete(() =>
            {
                infoPanle.gameObject.SetActive(false);
            });
            EDPanelsImg(false);
        }
    }

    public void EDRateUsPanel(bool status)
    {
        if (status)
        {
            rateUsPanel.gameObject.SetActive(true);
            EDPanelsImg(true);
            rateUsPanel.DOScale(new Vector3(1, 1, 1), windowsOpenAnimationDuration).SetEase(windowsOpenEaseType);
        }
        else
        {
            rateUsPanel.DOScale(new Vector3(0, 0, 0), windowsCloseAnimationDuration).SetEase(windowsCloseEaseType).OnComplete(() =>
            {
                rateUsPanel.gameObject.SetActive(false);
            });
            EDPanelsImg(false);
        }
    }

    public void EDPrivacyPanle(bool status)
    {
        if (status)
        {
            privacyPanel.gameObject.SetActive(true);
            EDPanelsImg(true);
            privacyPanel.DOScale(new Vector3(1, 1, 1), windowsOpenAnimationDuration).SetEase(windowsOpenEaseType);
        }
        else
        {
            privacyPanel.DOScale(new Vector3(0, 0, 0), windowsCloseAnimationDuration).SetEase(windowsCloseEaseType).OnComplete(() =>
            {
                privacyPanel.gameObject.SetActive(false);
            });
            EDPanelsImg(false);
        }
    }

    public void EDQuitPanel(bool status)
    {
        if (status)
        {
            quitPanle.gameObject.SetActive(true);
            EDPanelsImg(true);
            quitPanle.DOScale(new Vector3(1, 1, 1), windowsOpenAnimationDuration).SetEase(windowsOpenEaseType);
        }
        else
        {
            quitPanle.DOScale(new Vector3(0, 0, 0), windowsCloseAnimationDuration).SetEase(windowsCloseEaseType).OnComplete(() =>
            {
                quitPanle.gameObject.SetActive(false);
            });
            EDPanelsImg(false);
        }
    }

    public void EDSharePanel(bool status)
    {
        if (status)
        {
            sharePanel.gameObject.SetActive(true);
            EDPanelsImg(true);
            sharePanel.DOScale(new Vector3(1, 1, 1), windowsOpenAnimationDuration).SetEase(windowsOpenEaseType);
        }
        else
        {
            sharePanel.DOScale(new Vector3(0, 0, 0), windowsCloseAnimationDuration).SetEase(windowsCloseEaseType).OnComplete(() =>
            {
                sharePanel.gameObject.SetActive(false);
            });
            EDPanelsImg(false);
        }
    }

    public void EDGiftPanel(bool status)
    {
        if (status)
        {
            giftPanel.gameObject.SetActive(true);
            EDPanelsImg(true);
            giftPanel.DOScale(new Vector3(1, 1, 1), windowsOpenAnimationDuration).SetEase(windowsOpenEaseType);
        }
        else
        {
            giftPanel.DOScale(new Vector3(0, 0, 0), windowsCloseAnimationDuration).SetEase(windowsCloseEaseType).OnComplete(() =>
            {
                giftPanel.gameObject.SetActive(false);
            });
            EDPanelsImg(false);
        }
    }

    public void EDPanelsImg(bool status)
    {
        if (status)
        {
            panelsBGImg.gameObject.SetActive(true);
            panelsBGImg.DOFade(0.7f, windowsOpenAnimationDuration / 2);
        }
        else
        {
            panelsBGImg.DOFade(0, windowsOpenAnimationDuration * 1.25f).OnComplete(() =>
            {
                panelsBGImg.gameObject.SetActive(false);
            });
        }
    }

    //-------------------------------------------UI Panels Controles--------------------------------------------------------------//

    //-------------------------------------------UI Panels Functions--------------------------------------------------------------//
    public void Info()
    {

    }

    public void RateUs()
    {
        Application.OpenURL(rateUSLink);
    }

    public void Privacy()
    {
        Application.OpenURL(privacyLink);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void Share()
    {
        var shareSubject = AppNameString;
        var shareMessage = appDescriptionString + "\n" + shareLink;

        if (!Application.isEditor)
        {
            //Create intent for action send
            AndroidJavaClass intentClass =
                new AndroidJavaClass("android.content.Intent");
            AndroidJavaObject intentObject =
                new AndroidJavaObject("android.content.Intent");
            intentObject.Call<AndroidJavaObject>
                ("setAction", intentClass.GetStatic<string>("ACTION_SEND"));

            //put text and subject extra
            intentObject.Call<AndroidJavaObject>("setType", "text/plain");
            intentObject.Call<AndroidJavaObject>
                ("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), shareSubject);
            intentObject.Call<AndroidJavaObject>
                ("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareMessage);

            //call createChooser method of activity class
            AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity =
                unity.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject chooser =
                intentClass.CallStatic<AndroidJavaObject>
                ("createChooser", intentObject, "Share your high score");
            currentActivity.Call("startActivity", chooser);
        }
    }

    public void Gift()
    {

    }
    //-------------------------------------------UI Panels Functions--------------------------------------------------------------//
}
