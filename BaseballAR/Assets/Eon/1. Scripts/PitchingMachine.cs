using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PitchingMachine : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

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
