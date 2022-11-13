using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    private Text textToEdit;
    void Start()
    {
        textToEdit = GetComponent<Text>();
    }
 
    public void ChangeText()
    {
        textToEdit.text = "New Text";
    }
}
