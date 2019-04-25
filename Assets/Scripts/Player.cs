using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IPlayerState state;
    public Animator anim;
    public float WalkSpeed = 5f;
    public float CrouchSpeed = 2f;
    public IPlayerState State{ get => state; set => state = value;}

    private void Awake()
    {
        State = PlayerState.STATE_GROUNDED;
    }

    public void Update()
    {
        State.Update(this);
    }

    public void HandleInput(Input input)
    {
        State.HandleInput(this);
    }
    
    public bool IsGrounded()
    {
        //Check Ground Logic
        return true;
    }
}
