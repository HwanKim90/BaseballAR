using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PitchingMachine : MonoBehaviour
{
    public GameObject [] pitchingMachine;
    
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
        Invoke("Throw", 0.9f);
    }

    void Throw()
    {
            GameObject ball = Instantiate(pitchingMachine[0]);
            ball.transform.position = transform.position;
            strikeZone.SetActive(false);
        /*
        if (count == 1)
        {
            GameObject ball = Instantiate(pitchingMachine[1]);
            ball.transform.position = transform.position;
        }
        */
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
