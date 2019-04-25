using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnGroundState : PlayerState
{
    public override void HandleInput(Player character)
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ToState(character, STATE_JUMPING);
        else if (Input.GetKeyDown(KeyCode.LeftControl))
            ToState(character, STATE_CROUCHING);
    }

    public override void Update(Player character)
    {
        HandleInput(character);
        Move(character);
    }

    private void Move(Player character)
    {
        character.transform.position += new Vector3(base.ComputeMovementX() * Time.deltaTime * character.WalkSpeed, 0, 0);
    }
}
