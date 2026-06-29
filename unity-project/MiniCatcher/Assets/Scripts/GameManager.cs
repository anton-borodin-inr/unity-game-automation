using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject gameplayPanel;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text livesText;
    [SerializeField] private GameObject player;

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
        player.SetActive(true);

        UpdateGameplayUi();
    }

    private void ShowMainMenu()
    {
        score = 0;
        lives = 3;

        mainMenuPanel.SetActive(true);
        gameplayPanel.SetActive(false);
        player.SetActive(false);

        UpdateGameplayUi();
    }

    private void UpdateGameplayUi()
    {
        scoreText.text = $"Score: {score}";
        livesText.text = $"Lives: {lives}";
    }
}
