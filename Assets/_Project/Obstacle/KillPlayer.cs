using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other) {
        DeathScript deathScript = other.gameObject.GetComponent<DeathScript>();
        if (deathScript != null)
        {
            deathScript.Kill();
        }
    }
}
