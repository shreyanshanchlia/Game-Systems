using UnityEditor;
using UnityEngine;

public class Jump : MonoBehaviour
{
	class JumpJsonData
	{
		public string jumpJson2D, jumpJson3D;
	}
	JumpJsonData jumpJson;

	protected bool useRigidBody = true;
	protected enum JumpState
	{
		Grounded, Jumping, Falling
	};

	public enum MovementDimensions
	{
		D2, D3
	};
	protected JumpState currentState;
	[SerializeField] protected MovementDimensions movementDimensions;
	public GameObject GroundDetector;
	public float radius = 0.1f;

#if UNITY_EDITOR
	private void OnValidate()
	{
		Jump jump = gameObject.GetComponent<Jump>();
		if(jumpJson == null)
		{
			jumpJson = new JumpJsonData();
		}
		Jump2D jump2D = gameObject.GetComponent<Jump2D>();
		Jump3D jump3D = gameObject.GetComponent<Jump3D>();
		if (movementDimensions == MovementDimensions.D2 && jump2D == null)
		{
			jump3D.movementDimensions = MovementDimensions.D3;
			jumpJson.jumpJson3D = JsonUtility.ToJson(jump3D);
			Invoke(nameof(DestroyJump3D), 0f);
			Jump currentJump2D = Undo.AddComponent<Jump2D>(this.gameObject);
			JsonUtility.FromJsonOverwrite(jumpJson.jumpJson2D, currentJump2D);
			currentJump2D.jumpJson = jumpJson;
		}
		if (movementDimensions == MovementDimensions.D3 && jump3D == null)
		{
			jump2D.movementDimensions = MovementDimensions.D2;
			jumpJson.jumpJson2D = JsonUtility.ToJson(jump2D);
			Invoke(nameof(DestroyJump2D), 0f);
			Jump currentJump3D = Undo.AddComponent<Jump3D>(this.gameObject);
			JsonUtility.FromJsonOverwrite(jumpJson.jumpJson3D, currentJump3D);
			currentJump3D.jumpJson = jumpJson;
		}
	}
	private void DestroyJump2D()
	{
		Undo.DestroyObjectImmediate(gameObject.GetComponent<Jump2D>());
	}
	private void DestroyJump3D()
	{
		Undo.DestroyObjectImmediate(gameObject.GetComponent<Jump3D>());
	}
#endif
}

