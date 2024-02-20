using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating projectiles
    public GameObject eprojectilePrefab;

    public float speed = 5f;
    public float leftAndRightEdge = 7f;
    public float secondsBetweenProjectileShot = 1f;
    public float directionChangeCooldown = 2f;

    private float timeSinceLastDirectionChange;

    void Start()
    {
        // Shoot projectiles every second
        InvokeRepeating("ShootProjectile", 1f, secondsBetweenProjectileShot);
    }

    void ShootProjectile()
    {
        // Instantiate the EProjectile in front of the Enemy
        Vector3 spawnPosition = transform.position - transform.forward * 2f;
        Instantiate(eprojectilePrefab, spawnPosition, transform.rotation);
    }

    void Update()
    {
        // Randomly change direction with cooldown
        if (Time.time - timeSinceLastDirectionChange > directionChangeCooldown)
        {
            if (Random.value < 0.5f) // Adjust the chance as needed
            {
                speed = -speed;
                timeSinceLastDirectionChange = Time.time;
            }
        }

        // Basic Movement
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Clamp the position within the desired range
        float clampedX = Mathf.Clamp(transform.position.x, -leftAndRightEdge, leftAndRightEdge);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

 
    }
    
}
