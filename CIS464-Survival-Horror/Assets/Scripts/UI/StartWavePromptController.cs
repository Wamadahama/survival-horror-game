using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWavePromptController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.startWavePrompt = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
