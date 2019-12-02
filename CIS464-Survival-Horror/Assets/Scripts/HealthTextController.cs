using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextController : MonoBehaviour
{
    [SerializeField] Text m_text;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.healthTextController = this;
    }

    // We not callin this method every frame, we waiting for the bad boi to get hurt and then we're gonna update
    public void thePlayerGotHurtSoWeGottaUpdate()
    {
        m_text.text = "Health: " + GameManager.Instance.player.GetComponent<PlayerController>().health+"/100";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
