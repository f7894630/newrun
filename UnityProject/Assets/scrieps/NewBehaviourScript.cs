using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("speed")]
    [Range(0f, 100f)]
    public float speed = 3.5f;
    [Header("jump")]
    [Range(100, 2000)]
    public int jump = 300;
    [Header("standornot")]
    [Tooltip("判斷角色是否在陸地")]
    public bool isGround = false;
    [Header("name")]
    public string name = "YEE";
    [Header("2D 剛體")]
    public Rigidbody2D r2D;
    public Animator ani;
    private void Move()
    {
       float h = Input.GetAxisRaw("Horizontal");
        r2D.AddForce(new Vector2(5 * h, 0));
        ani.SetBool("run bitch run",h!=0);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGround == true)
        {
     
            isGround = false;
            r2D.AddForce(new Vector2(0, jump));
           // ani.SetBool("jump", jump != 0);
        }
    }

    private void dead()
    {

    }

    private void Update()
    {
        Move();
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ground")
        {
            isGround = true;
        }
    }







}
