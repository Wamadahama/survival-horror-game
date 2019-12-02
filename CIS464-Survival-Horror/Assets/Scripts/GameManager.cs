using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameObject player;
    public HealthTextController healthTextController;
    public ZombiesKilled zombiesKilled;

    public int enemiesAlive=-1;

    protected GameManager() { }

    private void Awake()
    {
      
    }
}
