using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckZone : MonoBehaviour
{
    public GameObject checkBalls;
    public Button test;
    public Text testText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
        }

        Vector3 checkPos = other.GetComponent<Transform>().position;

        //GameObject checkball = Instantiate(checkBalls);

        //checkball.transform.position = checkPos;

        test.transform.position = checkPos;
        
        testText.text = "1";
    }

    
}
