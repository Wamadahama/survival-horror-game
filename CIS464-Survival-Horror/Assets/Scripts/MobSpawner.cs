using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    [SerializeField] GameObject mobType;
    [SerializeField] int quantity;
    [SerializeField] float spawnRadius;

    // Start is called before the first frame update
    void Start()
    {
        //spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawn()
    {
        Vector3 position = GetComponent<Transform>().position;

        for (int i = 0; i < quantity; i++)
        { 
            Vector2 spawnLoc = new Vector2(position.x+Random.Range(-spawnRadius, spawnRadius), position.y+Random.Range(-spawnRadius, spawnRadius));

            GameObject enemy = (GameObject)Instantiate(mobType, new Vector3(spawnLoc.x, spawnLoc.y, -1), Quaternion.identity);
        }
    }
}
