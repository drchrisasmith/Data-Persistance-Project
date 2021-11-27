using System;
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
        ScoreManager.Instance.playerName = theName;
        textDisplay.GetComponent<Text>().text = "Good Luck " + theName; //displaying the message in the text field
        StartCoroutine(DelayCoroutine());
        
    }

    IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
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
