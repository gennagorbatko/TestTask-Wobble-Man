using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public int index = 0;
    bool flagKey = false;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Key")
        {
            flagKey = true;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "Grid" && flagKey)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Finish")
        {
            if (SceneManager.GetActiveScene().buildIndex != 3)
            {
                SceneManager.LoadScene(index);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FieldOfView")
        {
            SceneManager.LoadScene(5);
        }
    }
}
