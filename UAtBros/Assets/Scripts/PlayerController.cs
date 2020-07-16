using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector]public Pawn pawn;

    private void Start()
    {
        pawn = GetComponent<Pawn>();
    }

    private void Update()
    {
        //our direction to move
        float direction = 0;

        //if the player moves left
        if (Input.GetKey(KeyCode.A))
        {
            direction = -1;
        }
        
        //if the player moves right
        if(Input.GetKey(KeyCode.D))
        {
            direction = 1;
        }

        //if the player presses jump
        if(pawn.IsGrounded() && Input.GetKeyDown(KeyCode.W ))
        {
            pawn.Jump();

        }

        pawn.Move(direction);
    }
}
