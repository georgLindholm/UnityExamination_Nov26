using System;
using System.Collections;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed = 4f;
    
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.position += Vector2.down * obstacleSpeed * Time.deltaTime;
    }

    private IEnumerator DestroyObstacle()
    {
        yield return new WaitForSeconds(2f);
        
        Destroy(this.gameObject);
    }
}
