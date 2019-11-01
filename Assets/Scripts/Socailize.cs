using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socailize : MonoBehaviour
{
    [SerializeField] private string rateUsLink;

    [Space(10)]
    [SerializeField] private string sharingLink;
    [SerializeField] private string title;
    [SerializeField] private string sharMsg;
    public void Share()
    {

        var shareSubject = title;
        var shareMessage = sharMsg + "\n" + sharingLink;

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

    public void RateUs()
    {
        Application.OpenURL(rateUsLink);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
