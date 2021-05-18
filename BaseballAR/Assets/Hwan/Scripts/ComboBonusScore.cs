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
    float time;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        time = Timer.slTime.value;
    }

    public void CompareCnt()
    {
        if (hitCnt == throwCnt && CheckCombo.firstBallInStrkieZone && time > 0)
        {
            comboCnt++;
            comboTextUI.gameObject.SetActive(true);
            SetComboBonusScore();
            print(comboCnt);
            comboTextUI.text = comboCnt + "COMBO !";
        }
        else
        {
            comboTextUI.gameObject.SetActive(false);
            comboCnt = 0;
            hitCnt = 0;
            throwCnt = 0;
            comboTextUI.text = "MISS!";
            Pitcher.pitchTime = 2.1f;
        }
    }

    void SetComboBonusScore()
    {
        if (comboCnt == 3)
        {
            ScoreManager.instance.AddScore(comboScore);
            slTime.value += 5f;
            Pitcher.gameTime += 5f;
            //print("3√  ¡ı∞°");
            Pitcher.pitchTime -= 0.1f;
        }

        if (comboCnt == 7)
        {
            ScoreManager.instance.AddScore(comboScore * 2);
            slTime.value += 10f;
            Pitcher.gameTime += 10f;
            Pitcher.pitchTime -= 0.2f;
        }

        if (comboCnt == 10)
        {
            ScoreManager.instance.AddScore(comboScore * 3);
            slTime.value += 15f;
            Pitcher.gameTime += 15f;
            Pitcher.pitchTime -= 0.3f;
        }

        if (comboCnt == 15)
        {
            ScoreManager.instance.AddScore(comboScore * 4);
            slTime.value += 15f;
            Pitcher.gameTime += 15f;
            Pitcher.pitchTime -= 0.4f;
        }
    }
}

