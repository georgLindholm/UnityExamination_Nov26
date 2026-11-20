using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementForce = 3f;
    
    private Rigidbody2D rb;
    
    Vector2 input = Vector2.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {  
        input = new Vector2(Input.GetAxis("Horizontal") * movementForce, 0f);

        rb.linearVelocity = input;
    }
}
