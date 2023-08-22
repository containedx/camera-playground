﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleActorMovement : MonoBehaviour
{
    public float speed = 5.0f;


    private void Update()
    {
        MoveLeftRight();
    }

    private void MoveLeftRight()
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

        transform.position = currentPosition;
    }
}
