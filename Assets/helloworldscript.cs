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

    public string jump;
    public string kick;
    public string duck;
    public string input;
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
        WordReroll();
    }

    // Update is called once per frame
    void Update()
    {
        if (input.ToLower().Contains(jump.ToLower()))
        {
            jumpEvent.Invoke();
            WordReroll();
        }
        else if (input.ToLower().Contains(kick.ToLower()))
        {
            kickEvent.Invoke();
            WordReroll();

        }
        else if (input.ToLower().Contains(duck.ToLower()))
        {
            duckEvent.Invoke();
            WordReroll();
        }
    }

    public void UpdateInput(string _input)
    {
        input = _input;
    }

    public void WordReroll()
    {
        jump = (string)listofWords[Random.Range(0, listofWords.Count)];
        kick = (string)listofWords[Random.Range(0, listofWords.Count)];
        duck = (string)listofWords[Random.Range(0, listofWords.Count)];
    }
}
