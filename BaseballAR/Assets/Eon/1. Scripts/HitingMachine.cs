using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitingMachine : MonoBehaviour
{
    public GameObject hitingMachine;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickHit()
    {
        
        GameObject hitBall = Instantiate(hitingMachine);
        hitBall.transform.position = transform.position;
//        Rigidbody rb = hitBall.GetComponent<Rigidbody>();
//        rb.AddForce(hitingMachine.transform.forward * throwPower);
    }
}
