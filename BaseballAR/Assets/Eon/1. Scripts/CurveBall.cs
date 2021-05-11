using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurveBall : MonoBehaviour
{
    public GameObject Target;

    void Start()
    {
        Target = GameObject.Find("TargetTest");
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, 0.01f);
    }
}
