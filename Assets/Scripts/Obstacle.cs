using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed = 5f;
    
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.position += Vector2.down * obstacleSpeed * Time.deltaTime;
    }
}
