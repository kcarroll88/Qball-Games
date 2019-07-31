using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] Clouds[] clouds;
    [SerializeField] float minSpawnSpeed;
    [SerializeField] float maxSpawnSpeed;

    bool spawning = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawning)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnSpeed, maxSpawnSpeed));
            SpawnCloud();
        }
    }

    private void SpawnCloud()
    {
        var cloudIndex = UnityEngine.Random.Range(0, clouds.Length);
        Spawn(clouds[cloudIndex]);
    }

    private void StopSpawningCloud()
    {
        spawning = false;
    }

    private void Spawn(Clouds myCloud)
    {
        Clouds newCloud = Instantiate(myCloud, transform.position, Quaternion.identity) as Clouds;
        newCloud.transform.parent = transform;
    }

}
