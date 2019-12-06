using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButtonController : MonoBehaviour
{
    [SerializeField] GameObject panel; // The current UI panel
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(hideThis);
    }

    void hideThis()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
