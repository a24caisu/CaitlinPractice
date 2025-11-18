using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
public class PlayerAnimation : MonoBehaviour
{
    Animator PlayerAnimator;
   private bool isGrounded;
   private CircleCollider2D groundCheckCollider;
   private LayerMask groundLayer = ~0;
   
    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
        PlayerAnimator.SetBool("Run", false);
        PlayerAnimator.SetBool("Jump", false);
        
        groundCheckCollider = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Grounded();
        if (Input.GetKeyDown("d"))
        {
            PlayerAnimator.SetBool("Run", true);
        }
        if (Input.GetKeyUp("d"))
        {
            PlayerAnimator.SetBool("Run", false);
        }

        if (isGrounded == false)
        {
            
        }

        if (isGrounded == true)
        {
            PlayerAnimator.SetBool("Jump", false);
        }
    }
    private bool Grounded()
    {
       
        if (groundCheckCollider.IsTouchingLayers(groundLayer))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
