using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 starting;
    public Vector3 target;
    public Transform player;
    public float speed = 10; 
    // Start is called before the first frame update
    void Awake()
    {
        starting = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        // maybe something to lock to camera 
        target = new Vector3(player.position.x, player.position.y, transform.position.z);
        Vector3 velocity = (target - transform.position) * 10;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, 1.0f, Time.deltaTime);
    }
}
