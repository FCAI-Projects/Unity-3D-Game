using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeMenu : MonoBehaviour
{
    public Text time;
    public int player;
    private string playerText;
    private string min;
    private string sec;
    void Update()
    {

        if (player == 1)
        {
            playerText = "player 1:";
            min = Global.min.ToString("00");
            sec = Global.sec.ToString("00");
        } else
        {
            playerText = "player 2:";
            min = Global.min2.ToString("00");
            sec = Global.sec2.ToString("00");
        }
        HandleText(player);

    }

    public void HandleText(int play)
    {
        if(play == 1)
        {
            if (Global.IfDead >= 1)
            {
                time.color = Color.red;
                time.text = playerText + " " + "Game Over  " + min + " : " + sec;
            }
            else if (Global.IfWin >= 1)
            {
                time.text = playerText + " " + "Winner  " + min + " : " + sec;
            }
            else
            {
                time.color = Color.red;
                time.text = playerText + " " + min + " : " + sec;
            }
        } else
        {
            if (Global.IfDead2 >= 1)
            {
                time.color = Color.red;
                time.text = playerText + " " + "Game Over  " + min + " : " + sec;
            }
            else if (Global.IfWin2 >= 1)
            {
                time.text = playerText + " " + "Winner  " + min + " : " + sec;
            }
            else
            {
                time.color = Color.red;
                time.text = playerText + " " + min + " : " + sec;
            }
        }

    }
}
