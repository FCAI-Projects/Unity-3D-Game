using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeMenu : MonoBehaviour
{
    public Text time;

    void Update()
    {
        string min = Global.min.ToString("00");
        string sec = Global.sec.ToString("00");
        if (Global.IfDead == 1)
        {
            time.color = Color.red;
            time.text = "Game Over  " + min + " : " + sec;
        } else if(Global.IfWin == 1)
        {
            time.text = "Winner  " + min + " : " + sec;
        }
        else
        {
            time.text = min + " : " + sec;
        }


    }
}
