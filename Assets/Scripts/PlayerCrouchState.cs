using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouchState : PlayerState
{
    public override void OnEnterState(Player character)
    {
        character.anim.SetBool("IsCrouched", true);
    }

    public override void OnExitState(Player character)
    {
        character.anim.SetBool("IsCrouched", false);
    }

    public override void HandleInput(Player character)
    {
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            ToState(character, STATE_GROUNDED);
        }
    }

    public override void Update(Player character)
    {
        HandleInput(character);
        Move(character);
    }

    private void Move(Player character)
    {
        character.transform.position += new Vector3(base.ComputeMovementX() * Time.deltaTime * character.CrouchSpeed, 0, 0);
    }
}