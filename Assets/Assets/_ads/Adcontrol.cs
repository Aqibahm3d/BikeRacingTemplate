﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

// Example script showing how to invoke the Google Mobile Ads Unity plugin.
public class Adcontrol : MonoBehaviour //, IUnityAdsListener
{
    public bool forcoin;
    public static Adcontrol instace;
    private string GameId = "4744325";
    private bool testmode = false;
    private string videoAd = "Interstitial_Android";
    private string banner = "Banner_Android";
    string reward = "Rewarded_Android";
    public int rewardAmount = 10;
    private void Awake()
    {
        instace = this;
    }
    // Start is called before the first frame update
    void Start()
    {

        Advertisement.Initialize(GameId, testmode);

        //Advertisement.AddListener(this); //---RF

        showBanner();


    }


    public void showBanner()
    {

        StartCoroutine(ShowBannerWhenInitialized());
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
    }

    public void showAd()
    {
        //if (!Advertisement.IsReady(videoAd)) { return; } //----> RF
        //Advertisement.Show();
    }


    IEnumerator ShowBannerWhenInitialized()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(banner);
    }

    public void hideBanner()
    {
        Advertisement.Banner.Hide();
    }


    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        //if (Advertisement.IsReady(reward)) // ---> RF
        //{
        //    Advertisement.Show(reward);
        //}
        //else
        //{
        //    Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        //}
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            PlayerReward();
          //  AdManager.instance.give50points();
          // AdManager.instance.forcoin = false;

            // Reward the user for watching the ad to completion.
            //  GameManager.instance.rewardUser();
        }
        else if (showResult == ShowResult.Skipped)
        {
            //AdManager.instance.forcoin = false;
            // Do not reward the user for skipping the ad.

        }
        else if (showResult == ShowResult.Failed)
        {
           // AdManager.instance.forcoin = false;
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == reward)
        {
            // Optional actions to take when the placement becomes ready(For example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy()
    {
       // Advertisement.RemoveListener(this); //---> RF

    }






    public void PlayerReward()
    {
        PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) + 10);
        PlayerPrefs.Save();
      //  GameObject.FindObjectOfType<ShopWindow>().refreshScoreWindowCoins();
        //GameObject.FindObjectOfType<Achievements>().RefeshScoreFromShop();
    }
}