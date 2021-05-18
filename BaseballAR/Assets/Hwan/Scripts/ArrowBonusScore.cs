using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBonusScore : MonoBehaviour
{
    public static ArrowBonusScore instance;
    public GameObject[] arrows;
    public static bool isCorrect;

    int bonusScore = 100;
    int randomNum;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        for (int i = 0; i < arrows.Length; i++)  
        {
            arrows[i].SetActive(false);
        }

        randomNum = Random.Range(0, 3);
        DelaySetArrowObj();
    }

    void Update()
    {
        if (isCorrect)
        {
            DelaySetArrowObj();
            isCorrect = false;
        }
    }
     
    public void SetArrowObj()
    {
        
        for (int i = 0; i < arrows.Length; i++)
        {
            if (i == randomNum)
            {
                arrows[i].SetActive(true);
            }
            else
            {
                arrows[i].SetActive(false);
            }
        }
    }

    void DelaySetArrowObj()
    {
        Invoke("SetArrowObj", 1f);
    }

    public void SetArrowScore()
    {
        
        if (HittingRandom.xHitPower >= -90 && HittingRandom.xHitPower <= -30 && randomNum == 0)
        {
            Setting();
        }

        if (HittingRandom.xHitPower > -30 && HittingRandom.xHitPower <= 30 && randomNum == 1)
        {
            Setting();
        }

        if (HittingRandom.xHitPower > 30 && HittingRandom.xHitPower <= 90 && randomNum == 2)
        {
            Setting();
        }
    }       

   void Setting()
    {
        arrows[randomNum].SetActive(false);
        ScoreManager.instance.AddScore(bonusScore);
        randomNum = Random.Range(0, 3);
        isCorrect = true;
    }
}

    

        
            


