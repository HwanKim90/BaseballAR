using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Vector3 targetZone;
    float x;
    float y;
    //public float DestroySec = 3.0f;

    void Start()
    {
        transform.position = GameObject.Find("PitchingMachine").transform.position;
        //transform.position = new Vector3(0, 1.5f, 4.71f);
        x = Random.Range(-1.1f, 1.1f);
        y = Random.Range(-0.5f, 1.1f);
        targetZone = new Vector3(x, y, 2.76f);

        //Judge(x, y);
        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetZone, 0.3f);
        //Destroy(gameObject, DestroySec);
    }
/*
    void Judge(float x, float y)
    {
        if (x > -0.5f && x < 0.5f && y > 0.1f && y < 1.15f)
        {
            print("스트라이크");
        }
        else 
        {
            print("볼");
        }
        
    }
*/
}
