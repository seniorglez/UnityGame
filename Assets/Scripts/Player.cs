using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int movespeed;
    public int jumpPower;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    private Animator anim;
    private int facing;
    public int coins;//numerical variables are set to 0 by default
    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//I´m creating a reference to a RigidBody2D
        anim = GetComponent<Animator>();
        facing = 1;
       
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))//left
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);//Take care, in java you are not allowed to turn an integer negative like in c#
            anim.SetBool("Running", true);
            if(facing == 1)
            {
                transform.localScale = new Vector3(-1f, 1f, 1f);
                facing = 0;
            }
        }
        else if (Input.GetKey(KeyCode.D))//rigth
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            anim.SetBool("Running", true);
            if( facing== 0)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
                facing = 1;

            }
        }
        else
        {
            anim.SetBool("Running", false);
        }



        if (Input.GetKey(KeyCode.W) && onGround)//jump
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        
    }

    private void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);//Is true if the groundCheck transform is overlaping with anything that we defined as Ground
    }
}
