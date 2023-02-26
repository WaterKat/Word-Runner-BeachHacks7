using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerInput : MonoBehaviour
{
    public JumpScript jumpScript;
    public DuckScript duckScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && Input.GetButtonDown("Fire1"))
        {
            jumpScript.Jump();
        }
                if (Input.GetButton("Jump") && Input.GetButtonDown("Fire2"))
        {
           duckScript.Duck();
        }
    }
}
