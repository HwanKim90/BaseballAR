using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurveBall : MonoBehaviour
{
    public GameObject Target;

    int targetNum;

    void Start()
    {
        targetNum = Random.Range(0, 5);

        Target = GameObject.Find("Target/TargetTest" + targetNum);
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Target.transform.position, 0.07f);
    }
}
