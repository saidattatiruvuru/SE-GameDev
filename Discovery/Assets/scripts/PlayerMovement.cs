using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    float horizontalMove = 0f;

    public float speed = 50f;

    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        Debug.Log(Input.GetButtonDown("Jump"));

        if(Input.GetButtonDown("Jump"))
        {
            animator.SetBool("jump", true);
            jump = true;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("jump", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        jump = false;
    }
}
