using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating projectiles
    public GameObject eprojectilePrefab;

    // Speed at which the Enemy moves
    public float speed = 5f;

    // Distance where Enemy turns around
    public float leftAndRightEdge = 7f;

    // Chance that the Enemy will change di
    public float chanceToChangeDirection;

    // Rate at which Projectiles will be instantiate
    public float secondsBetweenProjectileShot = 10f;

    void Start () {
        // Shoot projectiles every second
        Invoke("ShootProjectile",2f);
    }

     void ShootProjectile() {                         
        // Instantiate the EProjectile in front of the Enemy
        Vector3 spawnPosition = transform.position - transform.forward * 2f;
        GameObject eprojectile = Instantiate<GameObject>(eprojectilePrefab, spawnPosition, Quaternion.identity);   
        eprojectile.transform.rotation = transform.rotation;
        Invoke("ShootProjectile", secondsBetweenProjectileShot);
    }

    void Update () {
        // Basic Movement
        Vector3 pos = transform.position;      
        pos.x += speed * Time.deltaTime;       
        transform.position = pos;

        // Changing Direction
        if (pos.x < -leftAndRightEdge) {      
           speed = Mathf.Abs(speed); // Move ri
       } else if (pos.x > leftAndRightEdge) {
           speed = -Mathf.Abs(speed); // Move l
       } 
    }
    
    void FixedUpdate(){
       if (Random.value < chanceToChangeDirection) {
            speed *= -1; // Change direction  
       }
    }
}
