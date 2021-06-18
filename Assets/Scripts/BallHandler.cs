using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody ball;
    private Camera cam;
    void Start()
    {
        ball = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log("Input.mousePosition");
            Debug.Log(Input.mousePosition);
            Debug.Log("cam.ScreenToWorldPoint(Input.mousePosition)");
            Ray mPosRay = cam.ScreenPointToRay(Input.mousePosition);
            Vector3 mPosRayDIR = mPosRay.direction;
            ball.AddForce(mPosRayDIR.x,0f,1f, ForceMode.Impulse);
        }
    }
}