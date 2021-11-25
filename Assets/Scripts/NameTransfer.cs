using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class NameTransfer : MonoBehaviour
{

    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text; //setting theName string variable to the value of the inputField
        textDisplay.GetComponent<Text>().text = "Welcome to the game " + theName; //displaying the message in the text field
    }

    public void Exit()
    {
#if UNITY_EDITOR

        EditorApplication.ExitPlaymode();
#else
        Application.Quit();

#endif

    }
}
