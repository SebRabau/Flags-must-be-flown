using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrideTimer : MonoBehaviour
{
    private float time;
    private float minutes;
    private float seconds;

    void Start()
    {
        time = 14; //14secs
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            SceneManager.LoadScene("Score");
        }
    }
}
