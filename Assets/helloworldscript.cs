using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//using random

public class helloworldscript : MonoBehaviour
{
    string jump;
    string kick;
    string duck;
    // Start is called before the first frame update
    void Start()
    {
        var lines = System.IO.File.ReadLines(@"Assets/message.txt");
        int randomNum = Random.Range(0,50);
        foreach (var item in lines) 
        {
            Debug.Log(item);
            //Debug.Log(lines[randomNum]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
