using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickBall : MonoBehaviour
{
    RectTransform ball;
    public float scaleSpeed = 5f;
    bool isClick;

    private void Start()
    {
        ball = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (isClick)
        {
            RippleEft();
        }
    }


    public void OnClickBall()
    {
        isClick = true;
    }

    void RippleEft()
    {
        ball.sizeDelta *= 1.1f;
    }
}
