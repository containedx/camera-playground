using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;
    public float speed = 2.0f;

    
    private void LateUpdate()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z;

        Vector3 nextPos = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);

        transform.position = nextPos;
    }
}
