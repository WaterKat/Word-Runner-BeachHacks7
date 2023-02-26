using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform target;
    public float offset_x = -2;
    public float offset_y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        while (Mathf.Abs(target.position.x - (transform.position.x+offset_x) )  > 2)
        {
            transform.position += new Vector3(Mathf.Sign(target.position.x - (transform.position.x+offset_x) ) * Time.deltaTime, 0, 0 );
        }
        while (Mathf.Abs(target.position.y - (transform.position.y+offset_y) )  > 1)
        {
            transform.position += new Vector3(0,Mathf.Sign(target.position.y - (transform.position.y+offset_y) ) * Time.deltaTime, 0 );
        }
    }
}
