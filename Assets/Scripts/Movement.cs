using System;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{
    public UnityEvent onDeathzone;
    
    [SerializeField] private float movementForce = 3f;
    
    private Rigidbody2D rb;
    
    Vector2 startPosition = Vector2.zero;
    Vector2 input = Vector2.zero;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {  
        input = new Vector2(Input.GetAxis("Horizontal") * movementForce, 0f);

        rb.linearVelocity = input;
    }

    private void Respawn()
    {
        transform.position = startPosition;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Deathzone")
        {
            Respawn();
            
            onDeathzone.Invoke();
        }
    }
}
