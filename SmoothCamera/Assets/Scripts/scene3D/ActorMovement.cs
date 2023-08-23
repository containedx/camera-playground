using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorMovement : MonoBehaviour
{

    public CharacterController characterController;
    public float speed = 5.0f;
    
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude <= 0.1f)
            return;

        characterController.Move(direction * speed * Time.deltaTime);
    }
}
