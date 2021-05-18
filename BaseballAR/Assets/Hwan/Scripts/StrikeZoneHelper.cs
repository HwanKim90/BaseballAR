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
    bool shaderEffect;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Ball"))
        {
            isStrike = false;
            ballCnt++;
            Hitting.stayTime = 0;
            //strikeZone.SetActive(true);
            
            other.GetComponentInChildren<Text>().text = ballCnt.ToString();

            if (isStrike == false) other.GetComponent<MeshRenderer>().material = green;
            Destroy(other.gameObject, 2f);

            ComboBonusScore.throwCnt++; 
        }
    }
}
     
     
    
