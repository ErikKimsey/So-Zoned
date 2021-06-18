using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState gameState;
    void Awake()
    {
        Instance = new GameManager();
    }
    void Start()
    {

        // UpdateGameState();
    }

    public void UpdateGameState(GameState newState)
    {
        switch (gameState)
        {
            case GameState.PlayerScore:
                break;
            case GameState.GameTimer:
                break;
            case GameState.GameOver:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState),newState, "Problem updating GameState");
        }
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
    GameOver,
}