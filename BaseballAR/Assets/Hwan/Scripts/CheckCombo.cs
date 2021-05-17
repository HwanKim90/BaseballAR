using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCombo : MonoBehaviour
{
    public static bool firstBallInStrkieZone;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            firstBallInStrkieZone = true;
            StartCoroutine(DelayCompareCnt());
        }
    }

    IEnumerator DelayCompareCnt()
    {
        yield return new WaitForSeconds(1f);
        ComboBonusScore.instance.CompareCnt();
        StrikeZone.isPitching = false;
        StrikeZone.dissolve = 0;
    }
}

