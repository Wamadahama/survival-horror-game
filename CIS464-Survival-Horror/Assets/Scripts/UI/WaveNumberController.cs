using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveNumberController : MonoBehaviour
{
    [SerializeField] Text m_text;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.waveNumberController = this;
    }

    // I'm not drunk anymore.... this just updates the wave number when a new wave starts
    public void updateWaveNumber()
    {
        m_text.text = "Wave: " + GameManager.Instance.waveNumber;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
