using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorMovement : MonoBehaviour
{

    public CharacterController characterController;
    public float speed = 15.0f;
    public float rotationSpeed = 5.0f;
    
    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = transform.forward * vertical;

        if (direction.magnitude <= 0.1f)
            return;

        characterController.Move(direction * speed * Time.deltaTime);
    }

    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");

        Vector3 newRotation = transform.eulerAngles + new Vector3(0f, mouseX * rotationSpeed, 0f);
        transform.eulerAngles = newRotation;
    }
}
