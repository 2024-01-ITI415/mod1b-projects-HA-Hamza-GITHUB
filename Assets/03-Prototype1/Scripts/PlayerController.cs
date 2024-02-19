using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0; 
    public TextMeshProUGUI countText;
    private int count;
    public GameObject winTextObject;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody>();
        //winTextObject.SetActive(false);
    }

    private void FixedUpdate() 
   {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);  
        rb.AddForce(movement * speed);
   }
   
   void OnTriggerEnter(Collider other) 
   {
        if (other.gameObject.CompareTag("EProjectile"))
        {
            Debug.Log("Collided, GG");
            Invoke("ReloadScene", 0f);

            // Call the ProjectileDestroyed method from the Prototype script
            //FindObjectOfType<Prototype>().ProjectileDestroyed();

            // Reload the scene
            //SceneManager.LoadScene("Main-Prototype 1");
        }
   }
    
    void OnMove (InputValue movementValue)
   {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x; 
        movementY = movementVector.y; 
   }

       private void ReloadScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
}
