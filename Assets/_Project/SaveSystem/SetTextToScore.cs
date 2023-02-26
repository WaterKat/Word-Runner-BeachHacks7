using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetTextToScore : MonoBehaviour
{
    public TextMeshProUGUI textObject;

    void Start()
    {
        if (textObject == null)
            Debug.Log("Missing Reference", this.gameObject);
        HighScoreBoard board = LoadSaveHighScore.GetBoard();
        textObject.text = board.GetTopTen();
        if (textObject.text.Length < 1)
        {
            textObject.text = "No scores yet...";
        }
    }
}
