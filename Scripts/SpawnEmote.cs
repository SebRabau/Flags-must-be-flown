using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEmote : MonoBehaviour
{
    private int score;
    private IEnumerator waiter;
    private float fireRate = 0.4f;
    private float nextFire;
    private int counter;

    //emotes
    public GameObject[] emotePrefab;
    public GameObject emote1;
    public GameObject emote2;
    public GameObject emote3;
    public GameObject emote4;
    public GameObject emote5;
    public GameObject emote6;

    //Spawns
    public GameObject[] spawns;
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    public GameObject s7;
    public GameObject s8;
    public GameObject s9;
    public GameObject s10;

    //Car
    public GameObject car;

    void Start()
    {
        score = Score.score;
        counter = score;
        emotePrefab = new GameObject[6] { emote1, emote2, emote3, emote4, emote5, emote6 };
        spawns = new GameObject[10] { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
    }

    void Update()
    {
        if(Time.time > nextFire && score > 0)
        {
            nextFire = Time.time + fireRate;
            FireEmotes();
            score--;
        }
    }

    void FireEmotes()
    {
        int rand = Random.Range(0, 6);
        int randS = Random.Range(0, 10);
        int randX = Random.Range(-5, 15);

        GameObject fire = (GameObject)Instantiate(
            emotePrefab[rand],
            spawns[randS].transform.position,
            spawns[randS].transform.rotation);

        var dir = new Vector2(car.transform.position.x, car.transform.position.y);
        dir.Normalize();
        fire.GetComponent<Rigidbody2D>().velocity = dir * 9f;
        IEnumerator bab = wait(2.5f);
        StartCoroutine(bab);    
    }

    private IEnumerator wait(float a)
    {
        yield return new WaitForSeconds(a);
    }
}
