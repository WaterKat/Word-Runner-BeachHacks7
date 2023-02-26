using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public float jumpforce;

    public AudioSource audioSource;

    [ContextMenu("JumpNow")]
    public void Jump()
    {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpforce);
        audioSource?.Play();
    }
}
