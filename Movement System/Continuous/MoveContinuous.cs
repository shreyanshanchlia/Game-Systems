using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveContinuous : MonoBehaviour
{
    public Vector3 velocity;

	private void Update()
	{
		this.transform.position += velocity * Time.deltaTime;
	}
}
