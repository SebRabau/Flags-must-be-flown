using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelect : MonoBehaviour
{
    //Sprites
    public Sprite[] chars;
    public Sprite f1;
    public Sprite f2;
    public Sprite f3;
    public Sprite f4;
    public Sprite f5;
    public Sprite f6;
    public Sprite f7;
    public Sprite f8;
    public Sprite m1;
    public Sprite m2;
    public Sprite m3;
    public Sprite m4;
    public Sprite m5;
    public Sprite m6;
    public Sprite m7;
    public Sprite m8;

    //Animations
    public RuntimeAnimatorController[] anims;
    public RuntimeAnimatorController f1a;
    public RuntimeAnimatorController f2a;
    public RuntimeAnimatorController f3a;
    public RuntimeAnimatorController f4a;
    public RuntimeAnimatorController f5a;
    public RuntimeAnimatorController f6a;
    public RuntimeAnimatorController f7a;
    public RuntimeAnimatorController f8a;
    public RuntimeAnimatorController m1a;
    public RuntimeAnimatorController m2a;
    public RuntimeAnimatorController m3a;
    public RuntimeAnimatorController m4a;
    public RuntimeAnimatorController m5a;
    public RuntimeAnimatorController m6a;
    public RuntimeAnimatorController m7a;
    public RuntimeAnimatorController m8a;

    //Char Preview
    private Sprite display;

    //Vars
    private int counter;

    //UI
    public Text text;

    //Audio
    public AudioClip click;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        display = GetComponent<SpriteRenderer>().sprite;
        chars = new Sprite[16] { f1, m1, f2, m2, f3, m3, f4, m4, f5, m5, f6, m6, f7, m7, f8, m8 };
        anims = new RuntimeAnimatorController[16] { f1a, m1a, f2a, m2a, f3a, m3a, f4a, m4a, f5a, m5a, f6a, m6a, f7a, m7a, f8a, m8a };
        counter = 0;
        GetComponent<SpriteRenderer>().sprite = chars[counter];
        GetComponent<Animator>().runtimeAnimatorController = anims[counter];

        GetComponent<Animator>().SetFloat("y", -1);

        text.text = (counter+1).ToString();

        charChoice.setPlayer(chars[counter]);
        charChoice.setPlayerAnim(anims[counter]);

        audioSource = GetComponent<AudioSource>();
    }

    public void right()
    {
        audioSource.PlayOneShot(click);

        if (counter < 15)
        {
            counter++;
        } else
        {
            counter = 0;
        }

        GetComponent<SpriteRenderer>().sprite = chars[counter];
        GetComponent<Animator>().runtimeAnimatorController = anims[counter];

        GetComponent<Animator>().SetFloat("y", -1);

        charChoice.setPlayer(chars[counter]);
        charChoice.setPlayerAnim(anims[counter]);

        text.text = (counter + 1).ToString();
    }

    public void left()
    {
        audioSource.PlayOneShot(click);

        if (counter > 0)
        {
            counter--;
        }
        else
        {
            counter = 15;
        }

        GetComponent<SpriteRenderer>().sprite = chars[counter];
        GetComponent<Animator>().runtimeAnimatorController = anims[counter];

        GetComponent<Animator>().SetFloat("y", -1);

        charChoice.setPlayer(chars[counter]);
        charChoice.setPlayerAnim(anims[counter]);

        text.text = (counter + 1).ToString();
    }
}
