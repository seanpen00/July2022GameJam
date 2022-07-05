using UnityEngine;
using System.Collections;

public class SmoothCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor = 3f;

    private void FixedUpdate()
    {
        if (target != null)
        {
            Follow();
        }
        else
        {

        }
    }

    private void Start()
    {
        transform.position = target.position;
    }

    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}