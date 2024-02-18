using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    [Header("Set in Inspector")]
    // Prefab for instantiating projectiles
    public GameObject eprojectilePrefab;

    // Speed at which the AppleTree moves
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Chance that the AppleTree will change di
    public float chanceToChangeDirection;

    // Rate at which Apples will be instantiate
    public float secondsBetweenProjectileShot = 1f;

    void Start () {
        // Shoot projectiles every second
        Invoke("ShootProjectile",2f);
    }

     void ShootProjectile() {                         
        GameObject eprojectile = Instantiate<GameObject>(eprojectilePrefab);
        eprojectile.transform.position = transform.position;
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
