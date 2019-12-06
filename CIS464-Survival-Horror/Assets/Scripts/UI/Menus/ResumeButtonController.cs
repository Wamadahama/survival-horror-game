using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Resume);
    }

    void Resume()
    {
        GameManager.Instance.pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        GameManager.Instance.isPaused = false;
    }
}
