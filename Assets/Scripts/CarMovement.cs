using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        Debug.Log("Game is starting");
    }

    private void Update()
    {
        var position = transform.position;

        Debug.Log(position);

        var step = _speed + Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            position.x += step;

        else if (Input.GetKey(KeyCode.S))
            position.x -= step;

        else if (Input.GetKey(KeyCode.A))
            position.z += step;

        else if (Input.GetKey(KeyCode.D))
            position.z -= step;

        transform.position = position;
        Debug.Log(position);
    }

    private void OnDestroy()
    {
        Debug.Log("Game is finished");
    }
}