using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public Text textStart;
    public Text textExit;
    public GameObject mainText;
    public GameObject mainText1;

    float[] rgb = {0, 1, 0};
    int index = 0;
    float dir = 0.01f;
    float dira = 0.01f;
    float rgba = 0;

    void Start()
    {
        iTween.MoveBy(mainText, iTween.Hash(
            "x", -1850,
            "y", 436,
            "time", 2,
            "easetype", iTween.EaseType.easeOutBounce,
            "oncomplete", "OnCompleteAni",
            "oncompletetarget", gameObject,
            "onupdate", "OnUpdateAni",
            "onupdatetarget", gameObject));

        iTween.MoveBy(mainText1, iTween.Hash(
            "delay", 1.5f,
            "x", -1850,
            "y", 436,
            "time", 2,
            "easetype", iTween.EaseType.easeOutBounce,
            "oncomplete", "OnCompleteAni",
            "oncompletetarget", gameObject,
            "onupdate", "OnUpdateAni",
            "onupdatetarget", gameObject));
    }

    void Update()
    {
        rgb[index] += dir;
        rgba += dira;

        if (rgb[index] >= 1 || rgb[index] <= 0)
        {
            index++;
            if (index == 3)
            {
                index = 0;
            }
            dir *= -1;
        }

        if (rgba >= 1 || rgba <= 0)
        {
            dira *= -1;
        }

        textStart.color = new Color(rgb[0], rgb[1], rgb[2], 1);
        textExit.color = new Color(1, 1, 1, rgba);
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("Eon_ALPHA");
        //SceneManager.LoadScene("KH_ALPHA");
    }

    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }

}
