using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickOnMainManu : MonoBehaviour
{    
    public void OnTuchPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void OnTuchExit()
    {
        Application.Quit();
    }
}
