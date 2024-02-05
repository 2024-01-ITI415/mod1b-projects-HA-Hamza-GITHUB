using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public TMP_Text scoreGT;             
    
    void Start() {
        // Find a reference to the ScoreCounter
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        // Get the Text Component of that GameO
        scoreGT = scoreGO.GetComponent<TMP_Text>();
        // Set the starting number of points to
        scoreGT.text = "0";
    }


    // Update is called once per frame
    void Update () {
        // Get the current screen position of t
        Vector3 mousePos2D = Input.mousePosition;
        // The Camera's z position sets how far
        mousePos2D.z = -Camera.main.transform.position.z;

        // Convert the point from 2D screen spa
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);    
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision coll) {  
        // Find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple") 
        {   
           Destroy(collidedWith);
           // Parse the text of the scoreGT in
            int score = int.Parse(scoreGT.text);
            // Add points for catching the appl
            score += 100;
            // Convert the score back to a stri
            scoreGT.text = score.ToString();
        }
    }
}
