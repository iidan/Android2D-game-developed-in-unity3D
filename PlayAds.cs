using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class PlayAds : MonoBehaviour {

    private int Counter;

    public void ShowAd()
    {
        Counter = PlayerPrefs.GetInt("CounterAds") + 1;
        PlayerPrefs.SetInt("CounterAds", Counter);

        if (PlayerPrefs.GetInt("CounterAds") == 3)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show("video");
            }
        }
        if (PlayerPrefs.GetInt("CounterAds") >= 3)
        {
            PlayerPrefs.SetInt("CounterAds", 0);
        }
    }
}
