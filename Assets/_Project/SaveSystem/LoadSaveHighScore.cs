using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveHighScore : MonoBehaviour
{
    public static void SaveBoard(HighScoreBoard _board){
        string boardJSON = JsonUtility.ToJson(_board);
        PlayerPrefs.SetString("Score", boardJSON);
        PlayerPrefs.Save(); 
    }
    public static HighScoreBoard GetBoard()
    {
        if (!PlayerPrefs.HasKey("Score"))
            PlayerPrefs.SetString("Score",JsonUtility.ToJson(new HighScoreBoard()));
        string boardJSON = PlayerPrefs.GetString("Score");
        HighScoreBoard board = new HighScoreBoard();
        JsonUtility.FromJsonOverwrite(boardJSON, board);
        return board;
    }
}
