using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    [HideInInspector] public Pawn pawn;

    public enum States
    {
        Idle, Run, Jump
    }

    public States currentState;

    [Header("Movement")]
    public float direction = 0;

    protected virtual void Start()
    {
        pawn = GetComponent<Pawn>();
    }

    protected void ChangeState(States newState)
    {
        currentState = newState;
    }

    protected virtual void Update()
    {
        switch(currentState)
        {
            case States.Idle:
                Idle();
                if(direction == -1)
                {
                    ChangeState(States.Run);
                }

                if(direction == 1)
                {
                    ChangeState(States.Run);
                }
                break;
            case States.Run:
                Run();

                if(direction == 0)
                {
                    ChangeState(States.Idle);
                }
                break;
            case States.Jump:
                Jump();
                break;
        }
    }

    protected virtual void Idle()
    {
        pawn.animator.SetBool("isRunning", false);
    }

    protected virtual void Run()
    {
        pawn.Move(direction);
        pawn.animator.SetBool("isRunning", true);

    }

    protected virtual void Jump()
    {
        pawn.Jump();
    }




}
