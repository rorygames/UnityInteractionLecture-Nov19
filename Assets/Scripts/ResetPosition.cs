using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [SerializeField] KeyCode _resetKey = KeyCode.None;
    [SerializeField] Transform _resetPosition = null;

    Rigidbody _rigidbody = null;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(_resetKey))
        {
            if(_rigidbody != null)
            {
                _rigidbody.velocity = Vector3.zero;
            }
            transform.position = _resetPosition.position;
        }
    }
}
