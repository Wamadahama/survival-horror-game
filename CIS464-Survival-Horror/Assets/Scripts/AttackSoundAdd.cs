using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSoundAdd : MonoBehaviour
{
    [SerializeField] int index;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.playerAttack[index] = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
