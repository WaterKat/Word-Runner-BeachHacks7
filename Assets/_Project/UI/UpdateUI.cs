using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    public TextMeshProUGUI jumpText;
    public TextMeshProUGUI kickText;
    public TextMeshProUGUI duckText;

    public helloworldscript hwscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jumpText.text = hwscript.jump;
        duckText.text = hwscript.duck;
        if (kickText!=null)
            kickText.text = hwscript.kick;
    }
}
