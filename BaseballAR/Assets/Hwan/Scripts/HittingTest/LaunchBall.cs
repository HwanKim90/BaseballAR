using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    public GameObject ballPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Launch();
    }

    void Launch()
    {
        GameObject ball = Instantiate(ballPrefab);
        ball.transform.position = transform.position;
    }
}
