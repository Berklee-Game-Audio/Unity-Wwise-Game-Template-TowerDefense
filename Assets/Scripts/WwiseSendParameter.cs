using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwiseSendParameter : MonoBehaviour {

    public string WwiseParameterToSend = "";
    public int WwiseParameterValueToSend = 0;
    static private GameObject WwiseGlobal;

    private void Awake()
    {
        WwiseGlobal = GameObject.Find("WwiseGlobal");
    }

    public void SendWwiseParameter(string WwiseParameterOverride = "", int WwiseParameterValueOverride = 0)
    {
        //WwiseGlobal = GameObject.Find("WwiseGlobal");

        if (WwiseGlobal == null)
        {
            Debug.Log("WwiseGlobal not found.");
            return;
        }

        if (WwiseParameterOverride != "")
        {
            //AkSoundEngine.PostEvent(WwiseEventOverride, WwiseGlobal);
            //Debug.Log(AkSoundEngine.GetRTPCValue(WwiseParameterOverride, ));
            //AkSoundEngine.SetRTPCValue ("time_remaining_percentage", timeRemaining / initialSettingOfTimeRemaining * 100.0f, GameObject.Find ("WwiseGlobal"));
            AkSoundEngine.SetRTPCValue(WwiseParameterOverride, WwiseParameterValueOverride, WwiseGlobal);
            Debug.Log("Posting the following parameter override to Wwise - " + WwiseParameterOverride + ": " + WwiseParameterValueOverride);
            return;
        }


        if (WwiseParameterToSend != "")
        {
            //AkSoundEngine.PostEvent(WwiseEventToPlay, WwiseGlobal);
            AkSoundEngine.SetRTPCValue(WwiseParameterToSend, WwiseParameterValueToSend, WwiseGlobal);
            Debug.Log("Posting the following parameter to Wwise - " + WwiseParameterToSend + ": " + WwiseParameterValueToSend);

        }
    }
}
