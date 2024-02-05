using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    static public int    score = 1000;
    
    void Start(){

    }
    void Awake() {                             
        // If the PlayerPrefs HighScore already
        if (PlayerPrefs.HasKey("HighScore")) {
            score = PlayerPrefs.GetInt("HighScore");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("HighScore", score);

    }

    // Update is called once per frame
    void Update () {
        TMP_Text gt = this.GetComponent<TMP_Text>();
        gt.text = "High Score: " + score;
        // Update the PlayerPrefs HighScore if 
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
