using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneMovement : MonoBehaviour
{
	public KeyCode laneUp, laneDown;
	[Tooltip("Positive lane distance")]
	public Vector3 laneDistance;
	public int numberOfLanes;
	[Tooltip("lane number starts from 0")]
	public int currentLaneNumber;

	public bool canSwitchLane = true;

	public GameObject[] additionalLaneObjects;

	private void Update()
	{
		if (canSwitchLane)
		{

			if (Input.GetKeyDown(laneUp) && currentLaneNumber > 0)
			{
				currentLaneNumber--;
				this.transform.position += laneDistance;
				foreach (GameObject additionalLane in additionalLaneObjects)
				{
					additionalLane.transform.position += laneDistance;
				}
			}
			if (Input.GetKeyDown(laneDown) && currentLaneNumber < numberOfLanes - 1)
			{
				currentLaneNumber++;
				this.transform.position -= laneDistance;
				foreach (GameObject additionalLane in additionalLaneObjects)
				{
					additionalLane.transform.position -= laneDistance;
				}
			}
		}
	}
}
