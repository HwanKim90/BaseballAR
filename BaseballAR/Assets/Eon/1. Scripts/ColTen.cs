using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColTen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "HitBall")
        {
            ScoreManager.instance.AddScore(10);
            Destroy(other.gameObject);
        }
    }
}
