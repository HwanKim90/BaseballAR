using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Slider slTime;

    void Start()
    {
        slTime = GetComponent<Slider>();
    }

    // Update is called once per frame
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
