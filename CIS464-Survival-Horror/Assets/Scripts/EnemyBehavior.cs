using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // GameManager singleton
    private GameManager gameManager;

    // These fields will be different for the different classes of enemies
    // Change them in the inspector
    public float maxHealth = 100;
    public float currHealth = 100;

    public int damage = 10;

    public float attackSpeed = 1;
    public float movementSpeed = 1;
    // This will be the maximum distance the enemy will chase the player from.
    public float chaseDistance = 100;

    private Transform transform;
    private Rigidbody2D rb;

    private bool touchingPlayer = false;
    public bool isAlive = true;

    private float attackTimer = 0; // Time until next attack

    void Start()
    {
        gameManager = GameManager.Instance;
        transform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        //Debug.Log(Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Function to be called when curHealth = 0
    void onDeath()
    {
        isAlive = false;
        GameManager.Instance.enemiesAlive--;
        GameManager.Instance.zombiesKilled.incrementKillCount();

        if (GameManager.Instance.enemiesAlive == 0)
        {
            GameManager.Instance.currentWave.NextWave();
        }
        Destroy(gameObject);
    }

    // Check to see if the unit made contact with the player
    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log(other.transform.name);

        // If the other object is the player, we are now touching the player
        if (string.Equals(other.transform.name, "Shot(Clone)"))
        {
            currHealth -= 20;
            
        }

        // If the other object is the player, we are now touching the player
        if (string.Equals(other.transform.name, "Player"))
        {
            Debug.Log("blah");
            touchingPlayer = true;
        }
    }

    // Check to see if the unit exited contact with the player
    void OnCollisionExit2D(Collision2D other)
    {
        // If the other object is the player, we are no longer touching the player
        if (string.Equals(other.transform.name, "Player"))
        {
            touchingPlayer = false;
        }
    }

    // If the enemy is touching the player do damage to player every time attackTimer reaches 0
    void attackPlayer()
    {
        if (touchingPlayer)
        {
            // If we're ready to attack, "attack" the player (subtract hitpoints = to damage)
            if (attackTimer <= 0)
            {
                // Basically what happens here is that the player gets a booboo when the zombie hits therrm
                // so we're all like "awww shitt mannnn we gotta let a dude know that they're in trouble"
                // So then we update the helath text by calling thePlayerGotHurtSoWeGottaUpdate
                // and then the health text is updated
                // Yeah, I write games
                GameManager.Instance.player.GetComponent<PlayerController>().health -= damage;
                GameManager.Instance.healthTextController.thePlayerGotHurtSoWeGottaUpdate();
                attackTimer = attackSpeed;
            }
            // Otherwise increment timer
            else
            {
                attackTimer -= Time.fixedDeltaTime;
            }

        }
    }

    void FixedUpdate()
    {
        // Get the vector difference between the enemy position and the player position
        Vector3 playerPos = gameManager.player.GetComponent<Transform>().position;
        Vector3 distToPlayer = transform.position - playerPos;
        Vector2 movement;

        float dx = 0, dy = 0;

        //Player player = gameManager.player.GetComponent<Player>();

        if (isAlive)
        {
            attackPlayer();

            if (currHealth <= 0)
            {
                onDeath();
            }

            // If the magnitude of the distance is within the enemies chase radius, move towards the player
            if (distToPlayer.magnitude <= chaseDistance)
            {
                if (playerPos.x > transform.position.x)
                {
                    dx = 1;
                }
                if (playerPos.x < transform.position.x)
                {
                    dx = -1;
                }
                if (playerPos.y > transform.position.y)
                {
                    dy = 1;
                }
                if (playerPos.y < transform.position.y)
                {
                    dy = -1;
                }

                movement = new Vector2(dx, dy);
                //Debug.Log(movement);
                rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
            }
        }
    }
}