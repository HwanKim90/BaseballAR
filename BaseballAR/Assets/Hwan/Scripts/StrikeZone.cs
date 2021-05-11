using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeZone : MonoBehaviour
{
    public Material yellow;
    
    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("Ball"))
        {
//            print("스트라이크 충돌!!");
            StrikeZoneHelper.isStrike = true;
            other.GetComponent<MeshRenderer>().material = yellow;
        }
    }
}