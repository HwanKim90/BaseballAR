using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColFive : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    /*
    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "Ball")
        {
            ScoreManager.instance.AddScore(5);
            Destroy(other.gameObject);
        }
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "HitBall")
        {
            ScoreManager.instance.AddScore(5);
            Destroy(other.gameObject, 1f);
        }
    }
}
