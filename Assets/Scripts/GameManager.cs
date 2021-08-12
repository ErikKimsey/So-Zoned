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
    [SerializeField] private GameObject lane;
    
    private bool gameIsActive;
    private bool gameIsOver;
    
    private ScoreManager scoreManager;
    public GameObject respawnTrigger;
    private float initWait;



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
        initWait = GetComponent<TitleManager>().textFadeOutBH;
        if (initWait != null)
        {
            StartCoroutine(Init());
        }
    }

    IEnumerator Init()
    {
        // - init Lane

        // - create Ball instance

        // - start Blackhole spawner
        yield return new WaitForSeconds(initWait + 1f);
        lane.SetActive(true);
        StartCoroutine(SpawnInititalBall());
    }

    IEnumerator SpawnInititalBall()
    {
        yield return new WaitForSeconds(1f);
        respawnTrigger.GetComponent<RespawnTriggerCollider>().SpawnInitialBall();
    }

    void Update()
    {

    }
}