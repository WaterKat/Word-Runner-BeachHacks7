using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.IO;


public class helloworldscript : MonoBehaviour
{
    public TextAsset textFile;
    public UnityEvent jumpEvent;
    public UnityEvent kickEvent;
    public UnityEvent duckEvent;

    public string jump;
    public string kick;
    public string duck;
    public string input_text;
    // Start is called before the first frame update
    [SerializeField] List<string> listofWords = new List<string>();

    void Start()
    {
        listofWords = new List<string>(textFile.text.Split('\n'));
        for (int i = 0; i < listofWords.Count; i++)
        {
            listofWords[i] = listofWords[i].ToLower().Trim();
        }
        WordReroll();
    }

    // Update is called once per frame
    void Update()
    {
        input_text = input_text.ToLower();
        Debug.Log("input_text "+input_text+" "+input_text.Length);
        Debug.Log("jump_text "+jump+" "+jump.Length);


        if (input_text.Contains(jump))
        {
            Debug.Log(input_text);

            jumpEvent.Invoke();
            WordReroll();
        }
        else if (input_text.Contains(kick))
        {
            kickEvent.Invoke();
            WordReroll();

        }
        else if (input_text.Contains(duck))
        {
            duckEvent.Invoke();
            WordReroll();
        }
    }

    public void UpdateInput(string _input)
    {
        input_text = _input.ToLower();
    }

    public void WordReroll()
    {
        jump = listofWords[Random.Range(0, listofWords.Count-1)].ToLower();
        kick = listofWords[Random.Range(0, listofWords.Count-1)].ToLower();
        duck = listofWords[Random.Range(0, listofWords.Count-1)].ToLower();
    }
}
