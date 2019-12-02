using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MobSpawner[] spawners = GetComponentsInChildren<MobSpawner>();
        
        foreach(MobSpawner spawner in spawners)
        {
            spawner.spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
