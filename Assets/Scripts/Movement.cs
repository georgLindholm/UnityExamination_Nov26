using System;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{
    public UnityEvent onDeathTrigger;
    public UnityEvent onScoreTrigger;
    public UnityEvent onTimerTrigger;
    
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
            
            onDeathTrigger.Invoke();
        }

        if (other.tag == "ScorePowerup")
        {
            onScoreTrigger.Invoke();
            
            Destroy(other.gameObject);
        }

        if (other.tag == "TimerPowerup")
        {
            onTimerTrigger.Invoke();
            
            Destroy(other.gameObject);
        }
    }
}
