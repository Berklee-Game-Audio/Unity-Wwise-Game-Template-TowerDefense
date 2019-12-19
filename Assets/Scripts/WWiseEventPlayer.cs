using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WWiseEventPlayer : MonoBehaviour {

    public string WwiseEventToPlay = "";
    static private GameObject WwiseGlobal;

    private void Awake()
    {
        WwiseGlobal = GameObject.Find("WwiseGlobal");
    }

    public void PlayWwiseEvent(string WwiseEventOverride = ""){
        if(WwiseGlobal == null){
            Debug.Log("PlayWwiseEvent - WwiseGlobal not found.");
            return;
        }

        if (WwiseEventOverride != "")
        {
            AkSoundEngine.PostEvent(WwiseEventOverride, WwiseGlobal);
            return;
        }


        if (WwiseEventToPlay != "")
        {
            AkSoundEngine.PostEvent(WwiseEventToPlay, WwiseGlobal);
        }
    }

    public void SetWwiseRTPC(string rtpcName, float value)
    {
        if (WwiseGlobal == null)
        {
            Debug.Log("SetWwiseRTPC - WwiseGlobal not found.");
            return;
        }

        AkSoundEngine.SetRTPCValue(rtpcName, value);

        return;
        

    }
}
