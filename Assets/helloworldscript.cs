using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.IO;


public class helloworldscript : MonoBehaviour
{
    public UnityEvent jumpEvent;
    public UnityEvent kickEvent;
    public UnityEvent duckEvent;

    string jump;
    string kick;
    string duck;
    string input;
    // Start is called before the first frame update
    List<string> listofWords = new List<string>();

    void Start()
    {

        var lines = System.IO.File.ReadLines(@"Assets/message.txt");
        //foreach (var item in lines) {Debug.Log(item);}
        foreach (var item in lines)
        {
            listofWords.Add(item);
        }
        jump = (string)listofWords[Random.Range(0, listofWords.Count)];
        kick = (string)listofWords[Random.Range(0, listofWords.Count)];
        duck = (string)listofWords[Random.Range(0, listofWords.Count)];
        Debug.Log("kick: " + kick);
        Debug.Log("jump: " + jump);
        Debug.Log("duck: " + duck);
    }

    // Update is called once per frame
    void Update()
    {
        if (input == jump)
        {
            jumpEvent.Invoke();
        }
        else if (input == kick)
        {
            kickEvent.Invoke();
        }
        else
        {
            duckEvent.Invoke();
        }
    }

    public void WordReroll()
    {
        jump = (string)listofWords[Random.Range(0, listofWords.Count)];
        kick = (string)listofWords[Random.Range(0, listofWords.Count)];
        duck = (string)listofWords[Random.Range(0, listofWords.Count)];
    }
}
