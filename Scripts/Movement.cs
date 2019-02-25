using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    //Player Vars
    private float speed;
    private Rigidbody2D rb;
    //private Vector2 _dir; //Last Direction
    //private RaycastHit2D hit;
    //private float rayL;
    //private LayerMask objects;
    private Animator anim;

    //UI
    public Text invtxt;
    public Text invName;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 15f;
        //rayL = 7f;
        //objects = LayerMask.GetMask("Raycast Hit");
        GetComponent<Animator>().runtimeAnimatorController = charChoice.playerAnim;
        anim = GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        if(GetComponent<SpriteRenderer>().sprite == null)
        {
            GetComponent<SpriteRenderer>().sprite = charChoice.player;
        }

        //Get Axis
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        movement.Normalize(); //No Diagonal Acceleration

        //Move
        rb.velocity = Vector2.zero; //Reset each call
        rb.AddForce(movement * speed, ForceMode2D.Impulse); //Impulse instant, no acceleration

        //Raycast directions        
        if(moveHorizontal == 1) //Facing Right
        {
            //_dir = new Vector2(1f, 0f);
            //hit = Physics2D.Raycast(transform.position, _dir, rayL, objects);
            anim.enabled = true;
            anim.SetFloat("x", 1.0f);
        } else if(moveHorizontal == -1) //Facing Left
        {
            //_dir = new Vector2(-1f, 0f);
            //hit = Physics2D.Raycast(transform.position, _dir, rayL, objects);
            anim.enabled = true;
            anim.SetFloat("x", -1.0f);
        } else if(moveVertical == 1) //Facing Up
        {
            //_dir = new Vector2(0f, 1f);
            //hit = Physics2D.Raycast(transform.position, _dir, rayL, objects);
            anim.enabled = true;
            anim.SetFloat("y", 1.0f);
        } else if(moveVertical == -1) //Facing Down
        {
            //_dir = new Vector2(0f, -1f);
            //hit = Physics2D.Raycast(transform.position, _dir, rayL, objects);
            anim.enabled = true;
            anim.SetFloat("y", -1.0f);
        } else
        {
            //hit = Physics2D.Raycast(transform.position, _dir, rayL, objects); //Draw Last Direction Ray
            anim.enabled = false;
            anim.SetFloat("x", 0.0f);
            anim.SetFloat("y", 0.0f);
        }

        //Draw ray in Scene View
        //Debug.DrawRay(transform.position, _dir*rayL, Color.green);

        //If it hits something
        /*if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);

            invName.text = hit.collider.gameObject.name;

            string[] inv = hit.collider.gameObject.GetComponent<GameInventory>().inv;

            invtxt.text = string.Join(",", inv);
        }*/
    }
}
