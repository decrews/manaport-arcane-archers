﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private GameStateManager gameStateManager;
    private Animator animator;
    private Player Player;

    void Start()
    {
        gameStateManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameStateManager>();
        Player = GetComponent<Player>();
        animator = GameObject.FindGameObjectWithTag("PlayerAnimator").GetComponent<Animator>(); //instantiates Animator GameObject
    }

    void Update()
    {
        if (gameStateManager.state == GameState.Main)
        {
            AnimatePlayer();
        }
    }

    public void AnimatePlayer()
    {
        Debug.Log(Player.move.y);
        if (Mathf.Abs(Player.move.x) < 0.05 || Mathf.Abs(Player.move.y) < 0.05)
        {
            animator.SetFloat("y", Player.move.y);
            animator.SetFloat("x", Player.move.x);
        }

        if (Player.movementType == MovementState.Idle)
        {
            animator.SetBool("idle", true);
        }
        else
        {
            animator.SetBool("idle", false);
        }

        if (Player.movementType == MovementState.Walk)
        {
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }

        if (Player.movementType == MovementState.Run)
        {
            animator.SetBool("running", true);
        }
        else
        {
            animator.SetBool("running", false);
        }

        if (Player.movementType == MovementState.Skid)
        {
            animator.SetBool("skidding", true);
        }
        else
        {
            animator.SetBool("skidding", false);
        }

        // animator.SetFloat("y", Player.move.y);
        // animator.SetFloat("x", Player.move.x);

        // Debug.Log(Player.facing);

        // switch (Player.facing)
        // {
        //     case FacingState.North:
        //         animator.SetFloat("facing", 0f);
        //         break;
        //     case FacingState.East:
        //         animator.SetFloat("facing", 1f);
        //         break;
        //     case FacingState.South:
        //         animator.SetFloat("facing", 2f);
        //         break;
        //     case FacingState.West:
        //         animator.SetFloat("facing", 3f);
        //         break;
        // }

        //     animator.SetBool("walking", (Mathf.Abs(Player.move.x) < 0.05 && Mathf.Abs(Player.move.y) < 0.05));
        //     if (!(Mathf.Abs(Player.move.x) < 0.05 && Mathf.Abs(Player.move.y) < 0.05)){
        //         animator.SetFloat("y", Player.move.y);
        //         animator.SetFloat("x", Player.move.x);
        //     }

        //    float isSprinting;
        //     if(Player.movementType == MovementState.Run){
        //             isSprinting = Player.sprintModifier;
        //         }else{
        //         isSprinting = 1;
        //         }

        //     if(isSprinting == 2){
        //             animator.SetBool("running", true);
        //         }else{
        //             animator.SetBool("running", false);
        //         }

        //if(Input.GetKeyDown(KeyCode.E))
        //    {
        //        animator.SetBool("isSkidding", true);
        //    }else
        //    {
        //        animator.SetBool("isSkidding", false);
        //    }
    }
}
