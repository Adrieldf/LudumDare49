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
    public GameObject PowerUp;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject deathMenu;
    [SerializeField]
    private GameObject completeMenu;
    [SerializeField]
    private TextMeshProUGUI deathMenuScore;
    [SerializeField]
    private TextMeshProUGUI deathMenuHighScore;
    [SerializeField]
    private AudioClip taDa;
    [SerializeField]
    private TextMeshProUGUI completeMenuScore;
    [SerializeField]
    private TextMeshProUGUI completeMenuHighScore;

    private AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        BugsEliminated = 0;
        Score = 0;
        scoreText.text = Score.ToString();
        pauseMenu.SetActive(false);
        deathMenu.SetActive(false);
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
        CountBugsKilled(enemy);
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
    private void CountBugsKilled(Enemies enemy)
    {
        switch (enemy)
        {
            case Enemies.Redbug:
            case Enemies.Pinkbug:
            case Enemies.Orangebug:
            case Enemies.Purplebug:
                BugsEliminated++;
                break;
            case Enemies.PowerUp:
                break;
            default:
                break;
        }
    }
    public void ShowDeathMenu()
    {
        PauseGame();
        deathMenuScore.text = Score.ToString();
        int hs = PlayerPrefs.GetInt("HighScore", 0);
        if (Score > hs)
        {
            hs = Score;
            PlayerPrefs.SetInt("HighScore", hs);
        }
        deathMenuHighScore.text = hs.ToString();
        deathMenu.SetActive(true);
    }
    public void CompleteGame()
    {
        PlayTaDa();
        PauseGame();
        completeMenuScore.text = Score.ToString();
        int hs = PlayerPrefs.GetInt("HighScore", 0);
        if (Score > hs)
        {
            hs = Score;
            PlayerPrefs.SetInt("HighScore", hs);
        }
        completeMenuHighScore.text = hs.ToString();
        completeMenu.SetActive(true);
    }
    public void PlayTaDa()
    {
        audioSource.clip = taDa;
        audioSource.Play();
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
    public void onRestartClick()
    {
        SceneManager.LoadScene("Game");
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
