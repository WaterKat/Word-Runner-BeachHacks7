using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartEvent : MonoBehaviour
{
    string jumpInput;
    string duckInput;
    string kickInput;
    string input;

    public UnityEvent jumped;
    public UnityEvent ducked;
    public UnityEvent kicked;

    [ContextMenu("Jump")]
    public void Jump()
    {
        jumped.Invoke();
    }
    [ContextMenu("Duck")]
    public void Duck()
    {
        ducked.Invoke();
    }
    [ContextMenu("Kick")]
    public void Kick()
    {
        kicked.Invoke();
    }
}
