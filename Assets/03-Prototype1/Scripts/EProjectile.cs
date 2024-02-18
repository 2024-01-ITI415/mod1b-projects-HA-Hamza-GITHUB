using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EProjectile : MonoBehaviour
{
    public static float     bottomY = -20f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY) {
            Destroy(this.gameObject); 
            
            // Get a reference to the Prototype
            Prototype apScript = Camera.main.GetComponent<Prototype>();
            // Call the public ProjectileDestroyed()
            apScript.ProjectileDestroyed(); 
        }
    }
}
