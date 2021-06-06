using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Vector3 offest;
    [SerializeField] private Transform target;
    [SerializeField] private float translateSpeed;
    [SerializeField] private float rotationSpeed;
    private void FixedUpdate()
    {
        HandleTranslate();
        HandleRotation();
        
    }

    private void HandleTranslate()
    {
        var targetPos = target.TransformPoint(offest);
        transform.position = Vector3.Lerp(transform.position, targetPos, translateSpeed * Time.deltaTime);
    }

    private void HandleRotation()
    {
        var direction = target.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}
