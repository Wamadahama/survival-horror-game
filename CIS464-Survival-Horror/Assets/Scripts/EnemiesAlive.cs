﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesAlive : MonoBehaviour
{
    public Text m_Text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_Text.text = "Enemies Alive: " + GameManager.Instance.enemiesAlive;
    }
}