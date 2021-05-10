using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float ballSpeed = 10;
    //public bool isStrike;

    void Update()
    {
        transform.Translate(Vector3.forward * ballSpeed * Time.deltaTime, Space.Self);
        Destroy(gameObject, 2f);
    }

    
}
