using UnityEngine;

public class AdmobTest : MonoBehaviour
{

    public void Start()
    {
    }




    public void ShowInterstitialAd()

    {
 
    }

 

    public void ShowRewardedVideo()
    {
#if UNITY_EDITOR
 StackManager.Instance.ContinueGameplay();
        GamePlay.Instance.InstantRescue();
        print("show rewarded video");

#endif
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
