using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private Ui ui;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject startGame;
    float score = 0;
    void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    void Start() {
        startGame.SetActive(true);
        gameOver.SetActive(false);
        Time.timeScale = 0f;
        ui.UpdateTextScore(score);
    }

    void Update()
    {
        
    }

    public void StartGame() {
        startGame.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver() {
        Time.timeScale = 0f;
        gameOver.SetActive(true);
    }
    
    public void UpdateScore() {
        score++;
        ui.UpdateTextScore(score);
    }
}
