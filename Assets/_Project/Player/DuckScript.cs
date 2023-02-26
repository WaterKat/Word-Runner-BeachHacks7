using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckScript : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public float duckForce;

    [ContextMenu("DuckNow")]
    public void Duck()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, -duckForce);
    }
}
