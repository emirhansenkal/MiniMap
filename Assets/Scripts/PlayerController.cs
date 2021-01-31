using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _movementSpeed = 10;
    private float _rotationalSpeed = 100;
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * _movementSpeed * Input.GetAxis("Vertical")));
        transform.Rotate(Vector3.up * (Time.deltaTime * _rotationalSpeed * Input.GetAxis("Horizontal")));
    }
}
