using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftOrRightCol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SphereMove.directionX *= -1;
        }
    }
}
