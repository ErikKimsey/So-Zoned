using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody ball;
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Vector3 mousePos = Input.mousePosition.normalized;
            Debug.Log(mousePos);
            ball.AddForce(0f,0f,1f, ForceMode.Impulse);
        }
    }
}