using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeZone : MonoBehaviour
{
    public Material yellow;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameObject.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        other.GetComponent<MeshRenderer>().material = yellow;
        other.GetComponent<BallMove>().isStrike = true;
        
    }



   

}