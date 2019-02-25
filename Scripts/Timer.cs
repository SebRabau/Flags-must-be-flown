using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float time;
    private float minutes;
    private float seconds;
    private Text timer;
    private bool ticking;

    public AudioClip tick;

    void Start()
    {
        time = 180; //3mins
        ticking = false;
        timer = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        minutes = (int)time / 60;
        seconds = (int)time % 60;
        timer.text = minutes.ToString() + " : " + seconds.ToString("F0");

        if(time <= 60 && timer.color != Color.red)
        {
            timer.color = Color.red;
        }

        if(time <= 13 && !ticking)
        {
            FindObjectOfType<AudioSource>().PlayOneShot(tick);
            ticking = true;
        }

        if(time <= 0)
        {
            SceneManager.LoadScene("Pride");
        }
    }
}
