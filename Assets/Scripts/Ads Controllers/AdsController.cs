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
        admob.RequestBanner();
    }

    public bool ShowIntertitial()
    {
        if (admob.IsIntersititialAdLoaded())
        {
            admob.ShowInterstitial();
            admob.RequestInterstitial();
            return true;
        }
        return false;
    }
}
