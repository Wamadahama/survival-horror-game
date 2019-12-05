using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Set the first wave of the zombie invasion!!!! */
public class FirstWave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.currentWave = gameObject.GetComponent<Wave>();
    }
}
