using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reselect : MonoBehaviour
{
    public TMP_InputField inputField;
    void Start()
    {
        inputField.ActivateInputField();
            inputField.Select();

    }
    private void Update() {
        if (Time.timeScale>0.05f)
        {
        inputField.ActivateInputField();
            inputField.Select();
        }
    }
    public void ReSelect()
    {
        inputField.ActivateInputField();
            inputField.Select();

    }
}
