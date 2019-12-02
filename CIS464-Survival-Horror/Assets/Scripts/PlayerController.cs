using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 100;
    public float speed = 1f;
    public Rigidbody2D rigidbody;
    public CharacterRender renderer;


    public GameObject projectile;
    public float shootSpeed = 300;
    Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        // This is an actual line of code I just typed...... sue meeeeeee
        cameraTransform = Camera.main.transform;
    }

    private void OnMouseDown()
    {

    }

    void spawnProjectile()
    {

        Vector3 shootDirection;
        shootDirection = Input.mousePosition;
        shootDirection.z = 0.0f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection -= transform.position;

        var a = projectile.GetComponent<SpriteRenderer>();

        //print(a.sprite);

        GameObject spellcast = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector2(0, 0)));
        var body = spellcast.GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(shootDirection.x * 5, shootDirection.y * 5);
    }

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        renderer = GetComponent<CharacterRender>();// GetComponentInChildren<CharacterRender>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spawnProjectile();
        }

        if(health<=0)
        {
            Destroy(gameObject);
        }

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
