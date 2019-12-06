using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionController : MonoBehaviour
{
    [SerializeField] int healingDone = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        PlayerController player = GameManager.Instance.player.GetComponent<PlayerController>();

        if (string.Equals(other.transform.name, "Player"))
        {
            if (player.health<100) {
                player.health += healingDone;
                GameManager.Instance.healthTextController.thePlayerGotHurtSoWeGottaUpdate();
                Destroy(gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
