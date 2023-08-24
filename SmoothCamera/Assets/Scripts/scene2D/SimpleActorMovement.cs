using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleActorMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 50.0f;

    private void Update()
    {
        Move();
        Rotate();
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
        }
    }

    private void Move()
    {
        Vector3 currentPosition = transform.position;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            currentPosition.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            currentPosition.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            currentPosition.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            currentPosition.y -= speed * Time.deltaTime;
        }

        transform.position = currentPosition;
    }
}
