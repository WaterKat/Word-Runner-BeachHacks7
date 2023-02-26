using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeping : MonoBehaviour
{
    public Transform playerTransform;
    public TextMeshProUGUI gui;
    public int score;
    Vector3 pos;
    private void Start() {
        pos = playerTransform.transform.position;
    }

    private void Update() {
        score = Mathf.FloorToInt((playerTransform.transform.position.x - pos.x)/5)*5;
        gui.text = $"Score : {score}";
    }
}
