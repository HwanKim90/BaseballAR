using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitcher : MonoBehaviour
{
    enum PitcherState
    {
        Idle,
        Pitch
    }

    PitcherState state;

    Animator anim;

    public GameObject pitching;
    public GameObject ballFactory;
    public GameObject[] pitchingMachine;
    public GameObject strikeZone;
    
    bool isPitching;

    float currTime;
    float pitchTime = 2.0f;

    float nowTime;
    float gameTime = 80.0f;

    int count;

    public float scaleOfTime = 1f;

    private Transform myTransform;

    void Start()
    {
        anim = GetComponent<Animator>();
        myTransform = transform;
    }

    void Update()
    {
        nowTime += Time.deltaTime;

        if(nowTime > 20 && nowTime < gameTime)
        {
            switch (state)
            {
                case PitcherState.Idle:
                    Idle();
                    break;
                case PitcherState.Pitch:
                    Pitch();
                    break;
            }
        }

        if(nowTime > 40.0f)
        {
            Time.timeScale = scaleOfTime + (nowTime / 80.0f);
        }  
        
    }

    void Idle()
    {
        PitcherRot();

        currTime += Time.deltaTime;

        if(currTime > pitchTime)
        {
            state = PitcherState.Pitch;
            anim.SetTrigger("Pitch");
            currTime = 0;
            isPitching = true;
        }
    }

    void Pitch()
    {
        Invoke("Throw", 0.9f);

        currTime += Time.deltaTime;

        if (currTime > pitchTime)
        {
            state = PitcherState.Idle;
            anim.SetTrigger("Idle");
            //ScoreManager.instance.AddScore(10);
            currTime = 0;
        }
    }

    void PitcherRot()
    {
        transform.rotation = Quaternion.Euler(0, 270, 0);
    }

    void Throw()
    {
        count = Random.Range(0, 3);
        
        if(isPitching == true)
        {
            if (count == 0)
            {
                GameObject ball = Instantiate(pitchingMachine[0]);
                ball.transform.position = ballFactory.transform.position;
            }
            if (count == 1)
            {
                GameObject ball = Instantiate(pitchingMachine[1]);
                ball.transform.position = ballFactory.transform.position;
            }
            if (count == 2)
            {
                GameObject ball = Instantiate(pitchingMachine[2]);
                ball.transform.position = ballFactory.transform.position;
            }
            strikeZone.SetActive(false);
            isPitching = false;
        }
    }
}
