using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject gameplayPanel;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text livesText;
    [SerializeField] private TMP_Text finalScoreText;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject fallingObject;

    private int score;
    private int lives;

    private void Start()
    {
        ShowMainMenu();
    }

    public void StartGame()
    {
        score = 0;
        lives = 3;

        mainMenuPanel.SetActive(false);
        gameplayPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        player.SetActive(true);
        fallingObject.SetActive(true);

        UpdateGameplayUi();
    }

    public void AddScore()
    {
        score++;
        UpdateGameplayUi();
    }

    public bool LoseLife()
    {
        if (lives <= 0)
        {
            return false;
        }

        lives--;
        UpdateGameplayUi();

        if (lives == 0)
        {
            ShowGameOver();
            return false;
        }

        return true;
    }

    private void ShowMainMenu()
    {
        score = 0;
        lives = 3;

        mainMenuPanel.SetActive(true);
        gameplayPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        player.SetActive(false);
        fallingObject.SetActive(false);

        UpdateGameplayUi();
    }

    private void ShowGameOver()
    {
        mainMenuPanel.SetActive(false);
        gameplayPanel.SetActive(false);
        gameOverPanel.SetActive(true);
        player.SetActive(false);
        fallingObject.SetActive(false);

        finalScoreText.text = $"Final Score: {score}";
    }

    private void UpdateGameplayUi()
    {
        scoreText.text = $"Score: {score}";
        livesText.text = $"Lives: {lives}";
    }
}
