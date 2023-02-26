using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBoard : MonoBehaviour
{
    [ContextMenu("Reset Board")]
    public void Reset()
    {
        HighScoreBoard board = new HighScoreBoard();
        LoadSaveHighScore.SaveBoard(board);
    }
    [ContextMenu("DisplayBoard")]
    public void CreateDisplayBoard()
    {
        HighScoreBoard board = new HighScoreBoard();
        board.AddRecord("John", 15);
        board.AddRecord("Ana", 10);
        board.AddRecord("Mike", 20);
        board.AddRecord("Alex", 50);
        board.AddRecord("Bill", 55);
        board.AddRecord("Steph", 15);
        board.AddRecord("Jimmy", 5);

        LoadSaveHighScore.SaveBoard(board);
    }
}
