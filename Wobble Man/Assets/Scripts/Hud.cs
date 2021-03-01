using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hud : MonoBehaviour
{
    public void OnTuchHome()
    {
        SceneManager.LoadScene(0);
    }
    public void OnTuchRefresh()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
