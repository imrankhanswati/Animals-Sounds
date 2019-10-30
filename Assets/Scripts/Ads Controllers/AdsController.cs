using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AdmobControllerScript))]
public class AdsController : MonoBehaviour
{
    public static AdsController instance;

    private AdmobControllerScript admob;

    private void Awake()
    {
        instance = this;
        admob = GetComponent<AdmobControllerScript>();
    }

    public void ShowBanner()
    {
        admob.RequestBanner();
    }

    public void HideBanner()
    {
        admob.HideBanner();
    }

    public void ShowIntertitial()
    {
        if (admob.IsIntersititialAdLoaded())
        {
            admob.ShowInterstitial();
        }
    }
}
