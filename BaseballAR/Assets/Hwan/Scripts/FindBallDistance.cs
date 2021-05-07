using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindBallDistance : MonoBehaviour
{
    public Transform ballPrefab;
    public Transform checkStrikeWall;

    float distance;
    
    void Start()
    {
        Slider slider = GetComponent<Slider>();
    }

    
    void Update()
    {
        distance = Vector3.Distance(ballPrefab.position, checkStrikeWall.position);
    }

    
}
