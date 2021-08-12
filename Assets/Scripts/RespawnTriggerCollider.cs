using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RespawnTriggerCollider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject newBall;
    [SerializeField] private GameObject respawnPoint;
    [SerializeField] private string ballTag;
    [CanBeNull] private GameObject m_newBall;

    void Start()
    {

    }

    public void SpawnInitialBall()
    {
        m_newBall = Instantiate(newBall, respawnPoint.transform.position, Quaternion.identity);
    }

    void RespawnBall()
    {
        if (m_newBall != null)
        {
            Destroy(m_newBall);
        }
        m_newBall = Instantiate(newBall, respawnPoint.transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (ballTag != null && other.gameObject.tag == ballTag)
        {
            RespawnBall();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}