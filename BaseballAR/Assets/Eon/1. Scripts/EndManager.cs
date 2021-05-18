using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    public Text textStart;
    public Text textExit;
    public Text textScore;
    public Text textScoreSub;

    float[] rgb = { 0, 1, 0 };
    int index = 0;
    float dir = 0.01f;
    float dira = 0.01f;
    float rgba = 0;
    float rgbm = 256;

    void Start()
    {
        SetData();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("activeScore", 3);

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
        textScore.color = new Color(176/rgbm, 32/rgbm, 45/rgbm, rgba);
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("Eon_ALPHA");
    }

    public void OnClickRetry()
    {
        SceneManager.LoadScene("Eon_ALPHA");
    }

    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }

    void activeScore()
    {
        textScore.gameObject.SetActive(true);
    }

    void SetData()
    {
        textScore.text = "" + GameManager.saveScore;
    }
}
