using UnityEngine;

public class AdmobTest : MonoBehaviour
{

    public void Start()
    {
    }




    public void ShowInterstitialAd()

    {
        print("show inter");

        if (Advertisements.Instance.IsInterstitialAvailable())

        {
            Advertisements.Instance.ShowInterstitial();
            print("show inter");

        }
    }

 

    public void ShowRewardedVideo()
    {
#if UNITY_EDITOR
 StackManager.Instance.ContinueGameplay();
        GamePlay.Instance.InstantRescue();
        print("show rewarded video");

#endif
        if (Advertisements.Instance.IsRewardVideoAvailable())
        {
            Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
        }else

        {
            Advertisements.Instance.ShowInterstitial();

        }
    }
   

    private void CompleteMethod(bool completed, string advertiser)
    {
        if (completed == true)
        {
            //give the reward
            StackManager.Instance.ContinueGameplay();
            GamePlay.Instance.InstantRescue();
        }
else
            {
                //no reward
        }
            }



  

}
