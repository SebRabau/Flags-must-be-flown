using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charChoice : MonoBehaviour
{
    public static Sprite player;
    public static RuntimeAnimatorController playerAnim;
    
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static void setPlayer(Sprite a)
    {
        player = a;
    }

    public static void setPlayerAnim(RuntimeAnimatorController a)
    {
        playerAnim = a;
    }
}
