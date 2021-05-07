using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeZone : MonoBehaviour
{
    public Material yellow;
    
    private void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        //print(other.tag);
        if (other.CompareTag("Ball"))
        {
            StrikeZoneHelper.isStrike = true;
            other.GetComponent<MeshRenderer>().material = yellow;

        }
        
        
    }



   

}