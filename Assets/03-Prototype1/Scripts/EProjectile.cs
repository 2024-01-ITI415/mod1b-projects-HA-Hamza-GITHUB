using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EProjectile : MonoBehaviour
{
    public static float     bottomZ = -15f; 
    public float initialSpeed = 5f; 
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Set initial velocity in the negative X-axis direction
        rb.velocity = new Vector3(0f, 0f, -initialSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bottomZ) {
            Destroy(this.gameObject); 
            
            // Get a reference to the Prototype
            //Prototype ptScript = Camera.main.GetComponent<Prototype>();
            // Call the public ProjectileDestroyed()
            //ptScript.ProjectileDestroyed(); 
        }
    }
}
