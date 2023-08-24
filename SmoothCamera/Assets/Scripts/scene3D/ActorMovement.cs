using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorMovement : MonoBehaviour
{

    public CharacterController characterController;

    public float speed = 30.0f;

    public float rotationSpeed = 50.0f;
    public float mouseSensitivity = 3.0f;

    private float targetHorizontalRotation;
    
    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = transform.forward * vertical;

        if (direction.magnitude <= 0.1f)
            return;

        characterController.Move(direction * speed * Time.deltaTime);
    }

    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");

        targetHorizontalRotation += mouseX * mouseSensitivity;
        Vector3 newRotation = new Vector3(0f, targetHorizontalRotation, 0f);

        Quaternion targetRotation = Quaternion.Euler(newRotation);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
