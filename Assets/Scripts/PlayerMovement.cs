using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D PlayerRB;
    public float jumpVelocity;
    bool Grounded;

    Animator anim;

    public Canvas canva;

    SpawnManagerScript spobject;
    public RepeatBackground background;
    public RepeatBackground ground;
    public RepeatBackground ground1;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spobject = FindObjectOfType<SpawnManagerScript>();
        background = GameObject.Find("Background").GetComponent<RepeatBackground>();
        ground = GameObject.Find("Ground").GetComponent<RepeatBackground>();
        ground1 = GameObject.Find("BottomGround").GetComponent<RepeatBackground>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Grounded)
            {
                JumpMethod();
                anim.SetTrigger("Jump");
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Grounded = true;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            anim.SetTrigger("Dead");
            spobject.CancelInvoke();
            background.xoffset = 0f;
            ground.xoffset = 0f;
            ground1.xoffset = 0f;
            canva.gameObject.SetActive(true);
        }
    }

    private void JumpMethod()
    {
        Grounded = false;
        PlayerRB.velocity = new Vector2(0, jumpVelocity);
    }
}
