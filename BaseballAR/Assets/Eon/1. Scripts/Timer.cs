using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Slider slTime;

    void Start()
    {
        slTime = GetComponent<Slider>();
    }

    void Update()
    {
        Invoke("CountTime", 20);
    }

    void CountTime()
    {
        if (slTime.value > 0.0f)
        {
            slTime.value -= Time.deltaTime;
        }
    }
}
