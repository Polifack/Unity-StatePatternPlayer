using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState : IPlayerState
{
    public static readonly PlayerOnGroundState STATE_GROUNDED = new PlayerOnGroundState();
    public static readonly PlayerJumpingState STATE_JUMPING = new PlayerJumpingState();
    public static readonly PlayerCrouchState STATE_CROUCHING = new PlayerCrouchState();


    public virtual void OnEnterState(Player character) { }
    public virtual void OnExitState(Player character) { }
    public virtual void ToState(Player character, IPlayerState targetState)
    {
        character.State.OnExitState(character);
        character.State = targetState;
        character.State.OnEnterState(character);
    }
    public abstract void Update(Player character);
    public abstract void HandleInput(Player character);

    public virtual float ComputeMovementX()
    {
        float direction = Input.GetAxis("Horizontal");
        return direction;
    }

}
