using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reselect : MonoBehaviour
{
    public TMP_InputField inputField;
    public void OnInspectorUpdate() {
        inputField.Select();
    }
}
