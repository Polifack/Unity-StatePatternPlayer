using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpingState : PlayerState
{
    public override void HandleInput(Player character)
    {
    }

    public override void Update(Player character)
    {
        if (character.IsGrounded())
        {
            ToState(character, STATE_GROUNDED);
        }
    }
}