using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColTenDouble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "HitBall")
        {
            ScoreManager.instance.AddScore(20);
            Destroy(other.gameObject);
        }
    }
}
