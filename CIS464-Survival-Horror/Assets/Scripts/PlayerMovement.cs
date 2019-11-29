using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rigidbody;
    public CharacterRender renderer; 
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        renderer = GetComponentInChildren<CharacterRender>(); 
   }

    // Update is called once per frame
    void Update()
    {
        Vector2 current = rigidbody.position; 

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        var target = (new Vector2(x, y) * speed);

        Vector2 move = target * speed; 
        Vector2 next = current + target * Time.fixedDeltaTime;
        renderer.SetSprite(move); 
        rigidbody.MovePosition(next); 

    }
}
