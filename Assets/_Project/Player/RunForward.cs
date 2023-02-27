using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunForward : MonoBehaviour
{
    public float speed = 1;
    public Vector2 direction = Vector2.right;
    [SerializeField] Rigidbody2D rb2d;

    //[SerializeField] Collider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }
}
