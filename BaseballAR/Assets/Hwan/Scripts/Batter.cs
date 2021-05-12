using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batter : MonoBehaviour
{
    enum BatterState
    {
        Idle,
        Swing
    }

    public float swingDelay = 1f;
    float currTime;
    BatterState state;
    Animator anim;

    bool isSwing;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        switch (state)
        {
            case BatterState.Idle:
                Idle();
                break;
            case BatterState.Swing:
                Swing();
                break;
        }
    }

    void Idle()
    {
        
        if (isSwing)
        {
            anim.SetTrigger("Swing");
            state = BatterState.Swing;
        }
    }

    public void OnclickSwing()
    {
        isSwing = true;
    }

    void Swing()
    {
        currTime += Time.deltaTime;
        
        if (currTime > swingDelay)
        {
            isSwing = false;
            currTime = 0;
            anim.SetTrigger("Idle");
            state = BatterState.Idle;
        }
    }
        
        

    
}
