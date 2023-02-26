using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSlowdown : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other) {
        AnimateSlowDown slowdownScript = other.gameObject.GetComponent<AnimateSlowDown>();
        if (slowdownScript!=null)
        {
            slowdownScript.delta+=Time.deltaTime*20;
        }
    }
}
