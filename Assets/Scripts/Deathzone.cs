using System;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    [SerializeField] private Vector2 targetPosition;
    [SerializeField] private float moveTime;
    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveTime * Time.deltaTime);
    }
}
