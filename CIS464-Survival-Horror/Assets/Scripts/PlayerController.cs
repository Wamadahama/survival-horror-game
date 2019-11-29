using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int Health = 100;
    public GameObject[] inventory;
    public int selectedItem = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {

    }

    void spawnProjectile()
    {

    }

    void switchItem()
    {
        if (selectedItem+1 > inventory.Length)
        {
            selectedItem = 0;
        } else
        {
            selectedItem++; 
        }
    }

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
