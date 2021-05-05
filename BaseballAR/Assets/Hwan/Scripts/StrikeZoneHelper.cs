using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeZoneHelper : MonoBehaviour
{
    public GameObject strikeZone;

    private void OnTriggerEnter(Collider other)
    {
        strikeZone.SetActive(true);
    }
}
