using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    protected override void Update()
    {
        direction = 0;

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
            //Jump();
        }

        base.Update();
    }
}
