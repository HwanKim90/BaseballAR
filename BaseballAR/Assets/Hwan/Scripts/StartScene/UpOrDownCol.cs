using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpOrDownCol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SphereMove.directionY *= -1;
        }
    }
}
