using UnityEngine;


[RequireComponent(typeof(PlayerHealth))]
public class PlayerDamageOnCollision : MonoBehaviour
{
    private PlayerHealth health;

    private void Awake()
    {
        health = GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            health.TakeDamage(1);
            Destroy(other.gameObject);
        }
    }
}

