using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameObject player;
    public GameObject startWavePrompt;
    public GameObject pauseMenu;

    public AudioSource[] playerHurt = new AudioSource[4];
    public AudioSource[] playerAttack = new AudioSource[4];
    public AudioSource[] enemyDead = new AudioSource[4];

    public Wave currentWave;
    public WaveNumberController waveNumberController;
    public HealthTextController healthTextController;
    public ZombiesKilled zombiesKilled;

    public int enemiesAlive=0;
    public int waveNumber;

    public bool isPaused=false; // If the game is paused

    protected GameManager() { }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                Time.timeScale = 0.0f;
                pauseMenu.SetActive(true);
                isPaused = true;
            }
            else
            {
                pauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
                isPaused = false;
            }
        }

        if (enemiesAlive == 0)
        {
            if (startWavePrompt.active == false)
                startWavePrompt.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                startWavePrompt.SetActive(false);
                waveNumber++;
                waveNumberController.updateWaveNumber();
                currentWave.startTheInvasion();
            }
        }
    }

    private void Awake()
    {
      
    }
}
