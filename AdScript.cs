using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdScript : MonoBehaviour {

    StartButton start;
    // Use this for initialization
    void Start()
    {
        showBannerAd();
        start = FindObjectOfType<StartButton>();
    }

    private void showBannerAd()
    {
        string adID = "ca-app-pub-3474361209608486/3779636251";

        //***For Testing in the Device***
        //AdRequest request = new AdRequest.Builder()
       //.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       //.AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
       //.Build();

        //***For Production When Submit App***
        AdRequest request = new AdRequest.Builder().Build();

        BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
        bannerAd.LoadAd(request);

        if (start.Actived)
        {
            bannerAd.Destroy();
        }
    }

}
