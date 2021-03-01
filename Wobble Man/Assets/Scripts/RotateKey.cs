using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateKey : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 2.0f, 0));
    }
}
