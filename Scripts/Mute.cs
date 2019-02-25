using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    public Slider slider;
    public bool muted = false;

    [System.NonSerialized]
    public float volume;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject.transform);
    }

    void OnEnable()
    {
        slider.onValueChanged.AddListener(changeVolume);
        changeVolume(slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource[] aS = new AudioSource[] { };
        aS = FindObjectsOfType<AudioSource>();

        for(int i=0; i<aS.Length; i++)
        {
            if (aS[i].volume > 0 && muted)
            {
                aS[i].volume = 0;
            }
            else if (aS[i].volume != volume && !muted)
            {
                aS[i].volume = volume;
            }
        }        
    }

    public void enableMute()
    {
        if(muted)
        {
            muted = false;
        } else
        {
            muted = true;
        }
    }

    public void changeVolume(float a)
    {
        volume = a;
    }
}
