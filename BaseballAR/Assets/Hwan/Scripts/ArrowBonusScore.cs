using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBonusScore : MonoBehaviour
{
    public static ArrowBonusScore instance;

    int bonusScore = 100;
    public GameObject[] arrows;

    int randomNum;
    public static bool isCorrect;

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
        
        if (HittingRandom.xHitPower >= -300 && HittingRandom.xHitPower <= -100 && randomNum == 0)
        {
            Setting();
        }

        if (HittingRandom.xHitPower > -100 && HittingRandom.xHitPower <= 100 && randomNum == 1)
        {
            Setting();
        }

        if (HittingRandom.xHitPower > 100 && HittingRandom.xHitPower <= 300 && randomNum == 2)
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
        print(bonusScore);
    }
}

    

        
            


