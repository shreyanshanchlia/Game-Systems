using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class MoveX : PlayerMovement
{
    public float speed = 10;


	#region cached variables
	float x;
	#endregion
	private void Update()
	{
		x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
		this.transform.position += Vector3.right * x;
	}
}
