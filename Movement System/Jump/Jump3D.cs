using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump3D : Jump
{
    public Vector3 JumpForce = Vector3.up * 10;
    [SerializeField] private KeyCode jumpKey;
	Rigidbody rb;
	public bool jumpAllowed = true;

	Jump3D()
	{
		movementDimensions = MovementDimensions.D3;
	}

	private void Start()
	{
		if(useRigidBody)
		{
			rb = GetComponent<Rigidbody>();
		}
	}
	void Update()
    {
        if(Input.GetKeyDown(jumpKey))
		{
			if (jumpAllowed)
			{
				JumpNow();
			}
		}
    }
	void JumpNow()
	{
		rb.AddForce(JumpForce, ForceMode.Impulse);
	}
}
