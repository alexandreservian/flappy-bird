using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private Ui ui;
    float score = 0;
    void Awake()
    {
        if (instance == null) {
            instance = this;
        }
        Time.timeScale = 1f;
    }

    void Start() {
        ui.UpdateTextScore(score);
    }

    void Update()
    {
        
    }

    public void GameOver() {
        Time.timeScale = 0f;
    }
    
    public void UpdateScore() {
        score++;
        ui.UpdateTextScore(score);
    }
}
