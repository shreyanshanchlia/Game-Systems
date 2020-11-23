using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSettings : MonoBehaviour
{
    public bool allowLaneSwitchingWhenJumping = true;

    [SerializeField] Jump jump;
    [SerializeField] LaneMovement laneMovement;

    public void JumpingState()
	{

	}
}
