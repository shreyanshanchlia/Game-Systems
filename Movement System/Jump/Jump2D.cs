using UnityEngine;

public class Jump2D : Jump
{
	
	public Vector2 JumpForce = Vector2.up * 5;
	[SerializeField] private KeyCode jumpKey;
	Rigidbody2D rb;
	public bool jumpAllowed = true;

	Jump2D()
	{
		movementDimensions = MovementDimensions.D2;
	}

	private void Start()
	{
		if (useRigidBody)
		{
			rb = GetComponent<Rigidbody2D>();
		}
	}
	void Update()
	{
		if (Input.GetKeyDown(jumpKey))
		{
			if (jumpAllowed)
			{
				JumpNow();
			}
		}
	}
	void JumpNow()
	{
		rb.AddForce(JumpForce, ForceMode2D.Impulse);
	}
}
