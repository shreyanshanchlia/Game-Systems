using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class MoveY : PlayerMovement
{
    public float speed = 10;


	#region cached variables
	float y;
	#endregion
	private void Update()
	{
		y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
		this.transform.position += Vector3.up * y;
	}
}
