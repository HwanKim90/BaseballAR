using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrikeZoneHelper : MonoBehaviour
{
    public GameObject strikeZone;
    int ballCnt;
    

    private void OnTriggerEnter(Collider other)
    {
        //ballCnt = Random.Range(1, 46);
        strikeZone.SetActive(true);
        ballCnt++;
        other.GetComponentInChildren<Text>().text = ballCnt.ToString();
        
    }
}
