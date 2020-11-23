using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSettings : MonoBehaviour
{
    public bool allowLaneSwitchingWhenJumping = true;

    Jump jump;
    LaneMovement laneMovement;

	private void Start()
	{
		jump = GetComponent<Jump>();
		laneMovement = GetComponent<LaneMovement>();
		if (jump != null && laneMovement != null)
		{
			jump.OnJumpStateChange += JumpStateChanged;
		}
	}
	void JumpStateChanged(Jump jump)
	{
		if(jump.jumpState == Jump.JumpState.Grounded)
		{
			laneMovement.canSwitchLane = true;
		}
		else
		{
			laneMovement.canSwitchLane = false;
		}
	}
}
