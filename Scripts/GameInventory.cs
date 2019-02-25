using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{

    public string[] inv;

    // Start is called before the first frame update
    void Start()
    {
        inv = new string[2];
        inv[0] = ("Watermelon");
        inv[1] = ("Apple");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
