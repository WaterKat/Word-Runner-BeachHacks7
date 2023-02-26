using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public float jumpforce = 5;

    [ContextMenu("JumpNow")]
    public void Jump()
    {
        rb2d.velocity += Vector2.up * jumpforce;
    }
}
