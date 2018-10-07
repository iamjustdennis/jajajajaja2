using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{

    public GameObject pony;
    public Vector3 spawnValues;

    void Start()
    {
        InvokeRepeating("SpawnWaves", 10, 5);
    }

    void SpawnWaves()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
        Quaternion spawnRotation = Quaternion.identity;
        var ponytry = Instantiate(pony, spawnPosition, spawnRotation) as GameObject;
        ponytry.AddComponent<PonyMove>();
    }
}
