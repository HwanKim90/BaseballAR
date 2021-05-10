using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurveBall : MonoBehaviour
{
    public Vector3 targetZone;
    float x;
    float y;
    int count;
    void Start()
    {
        transform.position = GameObject.Find("PitchingMachine").transform.position;
        
        x = Random.Range(-0.4f, 0.4f);
        y = Random.Range(-0.5f, 0.5f);

        targetZone = new Vector3(x, y, 2.94f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, targetZone, 0.1f);
    }
}
