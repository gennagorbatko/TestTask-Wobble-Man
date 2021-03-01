using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public bool useLookAt;
    public bool useTranslate;
    public float slerpTime = 0.7f;
    public float defaultPositionX = 0;
    public float defaultPositionY = 9;
    public float defaultPositionZ = 10;

    void Update()
    {
        if (useLookAt)
        {
            transform.LookAt(player.position, Vector3.up);
        }

        if (useTranslate)
        {
            transform.position = Vector3.Slerp(transform.position, new Vector3(player.position.x - defaultPositionX, player.position.y - defaultPositionY, player.position.z - defaultPositionZ), slerpTime);
        }
    }
}
