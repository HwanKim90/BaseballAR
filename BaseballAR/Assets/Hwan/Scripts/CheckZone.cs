using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckZone : MonoBehaviour
{
    public Material green;
    

    private void OnTriggerEnter(Collider other)
    {
        
        BallMove ball = other.GetComponent<BallMove>();
        ball.ballSpeed = 0;
        
        if (!ball.isStrike) other.GetComponent<MeshRenderer>().material = green;
    }
}


        
        







