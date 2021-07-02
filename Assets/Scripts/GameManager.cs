using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Game Settings")]
    public float defaultStartTime;
    public int score;
    
    private bool gameIsActive;
    private bool gameIsOver;

    // public Timer _timer;
    private ScoreManager scoreManager;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        // _timer.SaySumpin();
    }

    void Init()
    {
        // - set timer
        // - start timer
        // - set default score ("0")
        // - set *score* and *time* values in UI elements
        // - create Ball instance
        // - start Blackhole spawner
    }

    void PlayerScored()
    {

    }

    void UpdateUI_TimeRemaining()
    {

    }

    void UpdateUI_Score()
    {

    }

    void UpdateUI_FinalScore()
    {

    }

    void IsActiveGame()
    {

    }

    void RestartGame()
    {

    }

    void Update()
    {
        
    }
}