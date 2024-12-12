using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public GameObject textInput;

    public void Awake()
    {
        textInput.GetComponent<InputField>().text = DataManager.Instance.playerName;
    }

    public void StartNew()
    {
        DataManager.Instance.playerName = textInput.GetComponent<InputField>().text;
        SceneManager.LoadScene(1);
    } 
}
