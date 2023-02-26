using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathScript : MonoBehaviour
{
    public UnityEvent OnDeath;
    public AudioSource audioSource;

    public void Kill() 
    {
        audioSource.Play();
         OnDeath.Invoke();
         
}
}
