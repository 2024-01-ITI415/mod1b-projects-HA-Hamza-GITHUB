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
        // Load high score from PlayerPrefs
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        UpdateScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        // Update the score based on time
        score += Time.deltaTime;
        UpdateScoreUI();
    }

    // Display the current score and high score
    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + Mathf.Round(score);
        highScoreText.text = "High Score: " + Mathf.Round(highScore);
    }

    void Awake() {                             
        // If the PlayerPrefs HighScore already
        if (PlayerPrefs.HasKey("HighScore")) {
            score = PlayerPrefs.GetFloat("HighScore");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetFloat("HighScore", score);
    }

    // Reset the score and reload the scene
    public void ReloadScene()
    {
        if (score > highScore)
        {
            // Update the high score
            highScore = score;

            // Save the high score to PlayerPrefs
            PlayerPrefs.SetFloat("HighScore", highScore);
        }

        // Reset the current score
        score = 0f;

        // Reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
