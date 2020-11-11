using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class MoveZ : PlayerMovement
{
    public float speed = 10;


	#region cached variables
	float z;
	#endregion
	private void Update()
	{
		z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
		this.transform.position += Vector3.forward * z;
	}
}
