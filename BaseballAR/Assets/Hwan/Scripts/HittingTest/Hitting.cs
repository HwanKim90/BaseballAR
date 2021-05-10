using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitting : MonoBehaviour
{
    public Transform left;
    public Transform center;
    public Transform right;
    public GameObject hitBall;

    public float hitPower = 10f;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Hittings(left);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Hittings(center);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Hittings(right);
        }
    }
    void Hittings(Transform dirHit)
    {
        GameObject hit = Instantiate(hitBall);
        hit.transform.SetPositionAndRotation(dirHit.position, dirHit.rotation);
        Rigidbody rb = hit.GetComponent<Rigidbody>();
        rb.AddForce(dirHit.transform.forward * hitPower);
        //rb.AddRelativeForce(new Vector3(-hitPower, hitPower, hitPower));
    }

    

}
