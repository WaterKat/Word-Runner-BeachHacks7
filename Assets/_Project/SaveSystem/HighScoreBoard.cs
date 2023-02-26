using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HighScoreBoard
{
    public List<Record> scoreRecords;

    public HighScoreBoard()
    {
        scoreRecords = new List<Record>();
    }

    public void AddRecord(string name, int score)
    {
        if (scoreRecords == null)
            scoreRecords = new List<Record>();
        if (name.Length < 1)
            name = "Anon";
        if (score == 0)
            return;
        scoreRecords.Add(new Record(name, score));
    }

    public string GetTopTen()
    {
        if (scoreRecords == null)
            scoreRecords = new List<Record>();

        for (int i = 0; i < scoreRecords.Count; i++)
        {
            for (int j = i; j < scoreRecords.Count; j++)
            {
                if (scoreRecords[j].score > scoreRecords[i].score)
                {
                    Record temp = scoreRecords[i];
                    scoreRecords[i] = scoreRecords[j];
                    scoreRecords[j] = temp;
                }
            }
        }

        string output = "";
        for (int i = 0; i < Mathf.Min(scoreRecords.Count,10); i++)
        {
            output += $"{scoreRecords[i].name} :  {scoreRecords[i].score}";
            if  (i != Mathf.Min(scoreRecords.Count,10)-1)
            {
                output+='\n';
            }
        }
        return output;
    }
}
