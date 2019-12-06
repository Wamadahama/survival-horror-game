using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInitScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.music = gameObject.GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
