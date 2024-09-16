using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchingMachine : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] Collider pitchingMachine;
    [SerializeField] Transform launchPoint;
    [SerializeField] float pitchSpeed;

    private void Start()
    {
        InvokeRepeating("LaunchBall", 1f, Random.Range(0f, 8f));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchBall();
        }
    }

    void LaunchBall()
    {
        GameObject ball = Instantiate(ballPrefab, launchPoint.position, launchPoint.rotation);

        Rigidbody ballRb = ball.GetComponent<Rigidbody>();

        Collider ballCollider = ball.GetComponent<Collider>();

        Physics.IgnoreCollision(ballCollider, pitchingMachine);

        Vector3 launchDirection = -launchPoint.forward;

        ballRb.velocity = launchDirection * pitchSpeed;
    }
}
