using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float x = 0;
    public float velocidad = 10f;
    
    private void Start()
    {
        //_transform.position = transform.position = new Vector3(5f, 3f, 0f);
    }

    private void FixedUpdate()
    {
        x += 0.01f;
        _rigidbody.velocity = Vector2.right * velocidad;

        //x += 0.01f;
       // _transform.position = new Vector3(x, 3f, 0f);
    }
}
