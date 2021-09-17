using UnityEngine;

public class MoveContinuous : MonoBehaviour
{
    public Vector3 velocity;

    private void Update()
    {
        this.transform.position += velocity * Time.deltaTime;
    }
}