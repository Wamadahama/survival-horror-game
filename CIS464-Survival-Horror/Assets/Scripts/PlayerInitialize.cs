using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInitialize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
