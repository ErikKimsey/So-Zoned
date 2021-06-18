using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState gameState;

    [Header("Game Settings")]
    public float defaultStartTime;
    public int score;


    public static event Action<GameState> OnGameStateChanged;
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
        if (gameState != GameState.GameActive)
        {
            // UpdateGameState();
        }
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



    public void UpdateGameState(GameState newState)
    {
        switch (gameState)
        {
            case GameState.PlayerScore:
                break;
            case GameState.GameTimer:
                break;
            case GameState.GameActive:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState),newState, "Problem updating GameState");
        }
        OnGameStateChanged?.Invoke(newState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum GameState
{
    PlayerScore,
    GameTimer,
    GameActive
}