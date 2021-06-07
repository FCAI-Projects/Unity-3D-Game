using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void playGame()
    {
        Global.Player1 = false;
        Global.Player2 = false;
        Global.IfDead = 0;
        Global.IfWin = 0;
        Global.IfDead2 = 0;
        Global.IfWin2 = 0;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
