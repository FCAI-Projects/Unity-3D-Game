using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer2 : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finnished = false;
    public float t;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished)
            return;
        if (!Global.Player2)
        {
            t = Time.time - startTime;

            Global.min2 = ((int)t / 60);
            Global.sec2 = (t % 60);

            timerText.text = Global.min2.ToString("00") + " : " + Global.sec2.ToString("00");

        } else
        {
            timerText.color = Color.red;
        }
    }

    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.green;
        Global.IfWin2 = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
