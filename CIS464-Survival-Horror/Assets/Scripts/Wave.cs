using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    [SerializeField] GameObject next; // The next wave

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        
    }

    public void startTheInvasion()
    {
        MobSpawner[] spawners = GetComponentsInChildren<MobSpawner>();

        foreach (MobSpawner spawner in spawners)
        {
            spawner.spawn();
        }
    }

    public void NextWave()
    {
        //Debug.Log("What the fuck");
        if (next != null)
        {
            GameManager.Instance.currentWave = next.GetComponent<Wave>();
        }
        else
        {
            // This is the win condition, 
            // TODO add victory message 
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check to see if all enmies are dead, if they are, start the next wave
       
    }
}
