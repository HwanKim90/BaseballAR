using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PitchingMachine : MonoBehaviour
{
    public GameObject pitchingMachine;
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
        GameObject ball = Instantiate(pitchingMachine);
        ball.transform.position = transform.position;
        strikeZone.SetActive(false);
        //StrikeZoneHelper.isStrike = false;
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
