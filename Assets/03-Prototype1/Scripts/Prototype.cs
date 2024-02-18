using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prototype : MonoBehaviour
{
    public int lives = 1;
    void Start () {

    }
    
    public void ProjectileDestroyed() {             
        // Destroy all of the falling apples
        GameObject[] tProjectileArray=GameObject.FindGameObjectsWithTag("EProjectile");
        foreach (GameObject tGO in tProjectileArray) {
            Destroy(tGO);
        }
        
        
        // If there are no Baskets left, restar
        if (lives == 0) {
            SceneManager.LoadScene("Main-Prototype 1");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
