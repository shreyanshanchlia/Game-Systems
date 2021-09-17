using UnityEngine;

/// <summary>
/// Always Show Box Collider. If you still need to hide, then collapse the script, no need of removing
/// </summary>
[RequireComponent(typeof(BoxCollider))]
public class ShowBowCollider : MonoBehaviour
{
    private BoxCollider _boxCollider;

    private void OnDrawGizmos()
    {
        if (_boxCollider == null)
        {
            _boxCollider = GetComponent<BoxCollider>();
        }
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position + _boxCollider.center, Vector3.Scale(_boxCollider.size, transform.localScale));
    }
}
