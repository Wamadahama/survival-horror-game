using UnityEngine;
using System.Collections;

public class GameProgression : MonoBehaviour
{
    public int muxTick = 1; 
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ++muxTick;

        if (muxTick % 1000 == 0)
        {
            //GameObject.FindGameObjectsWithTag("")
        }
    }
}
