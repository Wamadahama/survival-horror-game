using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsButtonController : MonoBehaviour
{
    [SerializeField] GameObject optionsPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(showOptionsMenu);
    }

    void showOptionsMenu()
    {
        optionsPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
