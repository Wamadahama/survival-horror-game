using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombiesKilled : MonoBehaviour
{
    [SerializeField] Text m_text;

    int zombiesKilled = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.zombiesKilled = this;
    }
        
    // Call this function when a zombie is called to update the kill count.
    // We killing zombies in this b.... boys
    public void incrementKillCount()
    {
        zombiesKilled++;
        m_text.text = "Zombies Killed: " + zombiesKilled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
