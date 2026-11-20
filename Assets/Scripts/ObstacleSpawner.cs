using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Vector2 obstacleSpawnPoint = new Vector3(0, 8, 0);
    
    private void Start()
    {
        SpawnObstacle();
    }

    private void SpawnObstacle()
    {
        obstacleSpawnPoint.x = Random.Range(-2, 2);
        
        GameObject obstacle = Instantiate(obstaclePrefab, obstacleSpawnPoint, Quaternion.Euler(0, 0, Random.Range(-3, 3)));
        
        StartCoroutine(ObstacleCoroutine());
    }
    
    private IEnumerator ObstacleCoroutine()
    {
        yield return new WaitForSeconds(1);

        SpawnObstacle();
    }
}
