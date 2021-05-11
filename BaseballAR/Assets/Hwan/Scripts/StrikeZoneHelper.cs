using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrikeZoneHelper : MonoBehaviour
{
    public GameObject strikeZone;
    public Material green;
    
    public static bool isStrike;
    int ballCnt;
    
    private void OnTriggerEnter(Collider other)
    {
        //ballCnt = Random.Range(1, 46);
        if (other.CompareTag("Ball"))
        {
            isStrike = false;
//            print("º¼ Ãæµ¹!!");
            Hitting.stayTime = 0;
            strikeZone.SetActive(true);
            ballCnt++;
            other.GetComponentInChildren<Text>().text = ballCnt.ToString();
            if (isStrike == false) other.GetComponent<MeshRenderer>().material = green;

        }
    }
     
    
}
