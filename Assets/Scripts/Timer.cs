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

        float t = Time.time - startTime;

        string min = ((int)t / 60).ToString("00");
        string sec = (t % 60).ToString("00");

        timerText.text = min + " : " + sec;
    }

    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.green;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}