using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnWin : MonoBehaviour
{
    public int scenINdex = 0;
    public void OnTucNext()
    {
        SceneManager.LoadScene(scenINdex);
    }
    public void OnTuchBack()
    {
        SceneManager.LoadScene(0);
    }
}
