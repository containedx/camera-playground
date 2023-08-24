using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;
    public float speed = 5.0f;
    public float rotationSpeed = 10.0f;


    private void LateUpdate()
    {
        FollowTarget();
        FollowRotation();
    }


    private void FollowTarget()
    {
        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z;

        var distance = Vector3.Distance(targetPosition, transform.position);
        if (distance <= 0.1f)
            return;

        Vector3 nextPos = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
        transform.position = nextPos;
    }

    private void FollowRotation()
    {
        var angle = Quaternion.Angle(transform.rotation, target.rotation);
        if ( angle <= 0.1f)
            return;

        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, 10.0f * Time.deltaTime);
    }
}
