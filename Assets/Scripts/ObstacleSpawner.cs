using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private GameObject[] powerupPrefabs;
    [SerializeField] private Vector2 obstacleSpawnPoint = new Vector3(0, 8, 0);
    [SerializeField] private Vector2[] powerupSpawnPoints;
    
    private void Start()
    {
        SpawnObstacle();
        SpawnPowerups();
    }

    private void SpawnObstacle()
    {
        obstacleSpawnPoint.x = Random.Range(-2, 2);
        
        GameObject obstacle = Instantiate(obstaclePrefab, obstacleSpawnPoint, Quaternion.Euler(0, 0, Random.Range(-3, 3)));
        
        StartCoroutine(ObstacleCoroutine());
    }

    private void SpawnPowerups()
    {
        for (int i = 0; i < 3; i++)
        {
            if (Random.Range(0f, 100f) > 40f)
            {
                continue;
            }
            
            GameObject powerup = Instantiate(powerupPrefabs[Random.Range(0, powerupPrefabs.Length)], powerupSpawnPoints[i], Quaternion.Euler(0, 0, Random.Range(-3, 3)));
        }
        
        StartCoroutine(PowerupCoroutine());
    }
    
    private IEnumerator ObstacleCoroutine()
    {
        yield return new WaitForSeconds(1f);

        SpawnObstacle();
    }

    private IEnumerator PowerupCoroutine()
    {
        yield return new WaitForSeconds(1f);

        SpawnPowerups();
    }
}
