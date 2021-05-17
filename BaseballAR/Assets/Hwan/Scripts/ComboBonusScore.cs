using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboBonusScore : MonoBehaviour
{
    public static ComboBonusScore instance;
    public Text comboTextUI;
    public Slider slTime;

    public static int hitCnt;
    public static int throwCnt;
    int comboCnt;
    int comboScore = 50;

    void Awake()
    {
        instance = this;
    }

    public void CompareCnt()
    {
        if (hitCnt == throwCnt && CheckCombo.firstBallInStrkieZone)
        {
            comboCnt++;
            comboTextUI.gameObject.SetActive(true);
            SetComboBonusScore();
            print(comboCnt);
            comboTextUI.text = comboCnt + "Combo !";
        }
        else
        {
            comboTextUI.gameObject.SetActive(false);
            comboCnt = 0;
            hitCnt = 0;
            throwCnt = 0;
            print("miss");
        }
    }

    void SetComboBonusScore()
    {
        if (comboCnt == 3)
        {
            ScoreManager.instance.AddScore(comboScore);
            slTime.value += 3f;
            //print("3√  ¡ı∞°");
        }

        if (comboCnt == 6)
        {
            ScoreManager.instance.AddScore(comboScore);
            slTime.value += 6f;
        }

        if (comboCnt == 9)
        {
            ScoreManager.instance.AddScore(comboScore);
            slTime.value += 9f;
        }
    }
}

