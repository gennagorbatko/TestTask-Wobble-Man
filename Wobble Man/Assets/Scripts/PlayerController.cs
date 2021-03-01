using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody characterRigidbody;
    public float speed = 3.0f;
    public float moveForwardSpeed = 3.0f;
    public float rotationSpeed = 0.2f;
    public float brakeFactor = 100.0f;
    private Touch touch;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
        }
    }

    private void FixedUpdate()
    {
        switch (touch.phase)
        {
            case TouchPhase.Began:
                break;
            case TouchPhase.Moved:
                Move(touch);
                Rotate(touch);
                break;
            case TouchPhase.Stationary:
                MoveForward();
                break;
            case TouchPhase.Ended:
                Brake();
                break;
            case TouchPhase.Canceled:
                break;
        }
    }

    private void Rotate(Touch touch)
    {
        transform.Rotate(new Vector3(0, touch.deltaPosition.x * rotationSpeed, 0), Space.Self);
    }

    private void Move(Touch touch)
    {
        characterRigidbody.AddForce(new Vector3(touch.deltaPosition.x * speed * Time.deltaTime, 0, touch.deltaPosition.y * speed * Time.deltaTime));
    }

    private void MoveForward()
    {
        //characterRigidbody.AddForce(new Vector3(transform.forward.x * moveForwardSpeed * Time.deltaTime, 0, transform.forward.z * moveForwardSpeed * Time.deltaTime));
    }

    private void Brake()
    {
        characterRigidbody.AddForce(-brakeFactor * characterRigidbody.velocity);

        if (characterRigidbody.velocity.sqrMagnitude < 0.1)
        {
            characterRigidbody.Sleep();
        }

        characterRigidbody.rotation = transform.rotation;
    }
}