﻿using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*
     * Master Class for Player Movement
     */
#if UNITY_EDITOR
    [ContextMenu("Smooth Move/Move X")]
    public void AddMoveX()
	{
        Undo.AddComponent<MoveX>(this.gameObject);
    }
    [ContextMenu("Smooth Move/Move Y")]
    public void AddMoveY()
    {
        Undo.AddComponent<MoveY>(this.gameObject);
    }
    [ContextMenu("Smooth Move/Move Z")]
    public void AddMoveZ()
    {
        Undo.AddComponent<MoveZ>(this.gameObject);
    }
#endif
}
