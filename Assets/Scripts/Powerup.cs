using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Powerup : MonoBehaviour
{
    private Rigidbody2D rb;
    private float fallSpeed = 4f;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        fallSpeed = Random.Range(2f, 8f);
    }

    private void FixedUpdate()
    {
        rb.position -= new Vector2(0, fallSpeed * Time.deltaTime);
    }
}
