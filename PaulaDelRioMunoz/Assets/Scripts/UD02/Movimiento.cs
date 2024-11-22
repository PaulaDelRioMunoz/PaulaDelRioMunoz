using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private float _speed = 0.8f,
                  _turnSpeed = 90.0f;

    private float _horizontal,
                  _vertical;

    // Update is called once per frame
    void Update()
    {
        
        InputPlayer();
        Move();
        Turn();
    }

    private void InputPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

    }

    private void Move()
    {

        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);

    }

    private void Turn()
    {

        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);

    }
}
