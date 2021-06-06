using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
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

        t = Time.time - startTime;

        Global.min = ((int)t / 60);
        Global.sec = (t % 60);

        timerText.text = Global.min.ToString("00") + " : " + Global.sec.ToString("00");


    }

    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.green;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
