using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PitchingMachine : MonoBehaviour
{
    public GameObject [] pitchingMachine;
    //public GameObject pitchingMachine1;
    public GameObject strikeZone;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClickThrow()
    {
        int count = Random.Range(0,2);

        if(count == 0)
        {
            GameObject ball = Instantiate(pitchingMachine[0]);
            ball.transform.position = transform.position;
        }
        

        if(count == 1)
        {
            GameObject ball = Instantiate(pitchingMachine[1]);
            ball.transform.position = transform.position;
        }

        strikeZone.SetActive(false);    
        //StrikeZoneHelper.isStrike = false;
    }
/*
    public void OnClickThrowCurve()
    {
        GameObject ball = Instantiate(pitchingMachine1);
        ball.transform.position = transform.position;
        strikeZone.SetActive(false);
        //StrikeZoneHelper.isStrike = false;
    }
*/

    public void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
