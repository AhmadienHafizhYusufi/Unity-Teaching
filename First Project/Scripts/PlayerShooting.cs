using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * projectileSpeed;
    }
}
