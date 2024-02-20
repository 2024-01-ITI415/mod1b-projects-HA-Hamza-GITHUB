using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    private float score = 0f;
    private float highScore = 0f;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Update the score based on time
        score += Time.deltaTime;
        scoreText.text = "Score: " + Mathf.Round(score);

        highScoreText.text = "High Score: " + Mathf.Round(highScore);

        // Check if the current score is higher than the saved high score
        if (score > highScore)
        {
            // Update the high score
            highScore = score;

            // Save the high score to PlayerPrefs
            PlayerPrefs.SetFloat("HighScore", highScore);
        }

    }
}
