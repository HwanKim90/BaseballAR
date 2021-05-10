using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectingDistance : MonoBehaviour
{
    public GameObject targetObj;
    float ballDistance;

    void Start()
    {
        targetObj = GameObject.Find("DetectTarget");
    }
    void Update()
    {
        DetectingDistanceBall();
    }

    void DetectingDistanceBall()
    {
        Vector3 distance = targetObj.transform.position - transform.position;
        ballDistance = distance.magnitude;
        print(ballDistance);

        if (ballDistance <= 0.1f) Destroy(gameObject);
    }
}
        

