using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject Confetti1;
    public GameObject Confetti2;
    public GameObject Firework1;
    public GameObject Firework2;

    public GameObject[] effect;


    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Confetti();
        Firework();
    }

    void Confetti()
    {
        float timeVal = Timer.slTime.value;
        if(timeVal == 0){
            GameObject confetti = Instantiate(effect[0]);
            confetti.transform.position = Confetti1.transform.position;
            confetti.transform.position = Confetti2.transform.position;
        }
    }

    void Firework()
    {
        bool checkCombo = ArrowBonusScore.isCorrect;

        if (checkCombo == false)
        {
            GameObject firework = Instantiate(effect[1]);
            firework.transform.position = Firework1.transform.position;
            firework.transform.position = Firework2.transform.position;
        }
    }
}
