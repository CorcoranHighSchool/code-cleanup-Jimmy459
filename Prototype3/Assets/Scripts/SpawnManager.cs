
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Prefab for the obstacle to spawn
    [SerializeField] private GameObject obstaclePrefab;
    //Spawn Position
    [SerializeField] private Vector3 spawnPos = new Vector3(25.0f, 0.0f, 0.0f);

    //Spawn delay
    [SerializeField] private float spawnDelay = 2.0f;
    //Spawn Rate
    [SerializeField] private float spawnRate = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnDelay, spawnRate);
    }

    

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
