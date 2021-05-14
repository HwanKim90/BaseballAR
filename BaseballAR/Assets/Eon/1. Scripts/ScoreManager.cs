using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreUI;
    int scoreTotal;

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    public void AddScore(int score)
    {
        scoreTotal += score;
        scoreUI.text = "" + scoreTotal;
    }
}
