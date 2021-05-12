using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slTime;

    void Start()
    {
        slTime = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slTime.value > 0.0f)
        {
            slTime.value -= Time.deltaTime;
        }
        else
        {
            print("Time is Out");
        }
    }
}
