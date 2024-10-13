using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 10;

    void OnCollisionEnter(Collision other) {
        Health health = other.gameObject.GetComponent<Health>();
        if (health != null) {
            health.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
