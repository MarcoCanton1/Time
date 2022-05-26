using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public int freqInSeconds;
    float nextSpawnTime;
    public GameObject prefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextSpawnTime <= Time.time)
        {
            Instantiate(prefab);
            nextSpawnTime += freqInSeconds;
        }
    }
}
