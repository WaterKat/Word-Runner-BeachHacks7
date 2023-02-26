using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveScoreOnDeath : MonoBehaviour
{
    public ScoreKeeping scoreKeepingScript;
    public TMP_InputField inputField;
    public LoadScene sceneLoadScript;

    int score = 0;

    [ContextMenu("ForceDeath")]
    public void OnDied()
    {
        scoreKeepingScript.enabled = false;
        score = scoreKeepingScript.score;
        inputField.gameObject.SetActive(true);
        inputField.Select();
    }

    public void InputValueChanged(string _input){
        HighScoreBoard board = LoadSaveHighScore.GetBoard();
        board.AddRecord(_input, score);
        LoadSaveHighScore.SaveBoard(board);
        sceneLoadScript.Load();
    }
}
