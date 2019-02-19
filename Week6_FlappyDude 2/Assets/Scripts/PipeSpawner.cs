using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float spawnXPosition = -18;
    public GameObject pipePrefab;
    public float SpawnNewXPosition = -2;

    Transform lastSpawnedPipe;

    void Start()
    {
       // Instantiate(pipePrefab, new Vector3(spawnXPosition, 0, 0), Quaternion.identity);
    }


    void Update()
    {
        if (lastSpawnedPipe == null)
        {
            lastSpawnedPipe = Instantiate (pipePrefab, new Vector3(spawnXPosition, 0, 0), Quaternion.identity).transform;
        }

        else
        {
            if (lastSpawnedPipe.position.x < SpawnNewXPosition)
            {
                lastSpawnedPipe = Instantiate(pipePrefab, new Vector3(spawnXPosition, 0, 0), Quaternion.identity).transform;
            }
        }
    }
}
