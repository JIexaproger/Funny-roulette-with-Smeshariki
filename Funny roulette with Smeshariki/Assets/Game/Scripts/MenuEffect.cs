using System;
using System.Collections;
using UnityEngine;

public class MenuEffect : MonoBehaviour
{
    [SerializeField] float _moveSpeed;

    [SerializeField] float _minPosY;
    [SerializeField] float _maxPosY;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - _moveSpeed * Time.deltaTime, transform.position.z);
        if (transform.position.y <= _minPosY)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + MathF.Abs(_minPosY) + MathF.Abs(_maxPosY), transform.position.z);
        }
    }

}
