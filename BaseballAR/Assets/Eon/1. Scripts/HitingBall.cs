using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitingBall : MonoBehaviour
{
    public Vector3 fallZone;
    //float x;
    float z;
    public float DestroySec = 3.0f;

    void Start()
    {
        transform.position = new Vector3(-0.14f, 0.75f, -3.56f);
        //x = Random.Range(-8.93f, 8.93f);
        z = Random.Range(5.0f, 16.82f);
        fallZone = new Vector3(-0.14f, 0, z);

        Judge(z);
    }

    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, fallZone, 0.02f);
        Destroy(gameObject, DestroySec);
    }

    void Judge(float z)
    {
        if (z <= 7.71)
        {
            print("안타! : 50점");
        }
        if (z <= 12.22 && z > 7.71)
        {
            print("2루타! : 100점");
        }
        else
        {
            print("홈런! : 200점");
        }
    }
}
