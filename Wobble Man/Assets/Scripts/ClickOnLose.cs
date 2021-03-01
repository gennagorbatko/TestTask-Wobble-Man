using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClickOnLose : MonoBehaviour
{
    public void OnTuchrefrsh()
    {
        SceneManager.LoadScene(2);
    }

    public void OnTuchBack()
    {
        SceneManager.LoadScene(0);
    }
}
