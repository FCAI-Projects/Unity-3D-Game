using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Global : MonoBehaviour
{
    public static int min;
    public static float sec;
    public static int min2;
    public static float sec2;
    public static int IfDead = 0;
    public static int IfWin = 0;
    public static int IfDead2 = 0;
    public static int IfWin2 = 0;
    public static bool Player1 = false;
    public static bool Player2 = false;

    public static void End()
    {
        Debug.Log(Player1 + " " + Player2);
        if (Player1 && Player2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
