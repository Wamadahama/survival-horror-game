using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumeSliderController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Slider>().value = GameManager.Instance.music.volume;
        gameObject.GetComponent<Slider>().onValueChanged.AddListener(updateVolume);
    }

    private void updateVolume(float arg0)
    {
        GameManager.Instance.music.volume = gameObject.GetComponent<Slider>().value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
