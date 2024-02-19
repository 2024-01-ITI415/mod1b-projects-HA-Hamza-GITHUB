using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prototype : MonoBehaviour
{
    void Start () {

    }
    
    public void ProjectileDestroyed() {             
        GameObject[] tProjectileArray=GameObject.FindGameObjectsWithTag("EProjectile");
        foreach (GameObject tGO in tProjectileArray) {
            Destroy(tGO);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
