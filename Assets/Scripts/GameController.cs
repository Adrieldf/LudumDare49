using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public int BugsEliminated;
    public int Score;
    public bool GameIsPaused = false;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private GameObject pauseMenu;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        BugsEliminated = 0;
        Score = 0;
        pauseMenu.SetActive(false);
        UnpauseGame();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameIsPaused)
        {
            pauseMenu.SetActive(true);
            PauseGame();
        }
    }

    public void PauseGame()
    {
        GameIsPaused = true;
        Time.timeScale = 0;
    }
    public void UnpauseGame()
    {
        GameIsPaused = false;
        Time.timeScale = 1;
    }
    public void AddScore(Enemies enemy)
    {
        switch (enemy)
        {
            case Enemies.Redbug:
                IncrementScore(100);
                break;
            case Enemies.Pinkbug:
                IncrementScore(200);
                break;
            case Enemies.Orangebug:
                IncrementScore(500);
                break;
            case Enemies.Purplebug:
                IncrementScore(1000);
                break;
            case Enemies.PowerUp:
                IncrementScore(5000);
                break;
            default:
                break;
        }
    }
    private void IncrementScore(int value)
    {
        Score += value;
        scoreText.text = Score.ToString();
    }


    public void onContinueClick()
    {
        pauseMenu.SetActive(false);
        UnpauseGame();

    }
    public void onMainMenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public enum Enemies
    {
        Redbug,
        Pinkbug,
        Orangebug,
        Purplebug,
        PowerUp,

    }
}
