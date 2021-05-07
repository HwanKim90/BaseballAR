using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIt : MonoBehaviour
{
    public float hitPower = 15000f;
    public GameObject hitBall;
    Rigidbody rb;

    private void Start()
    {
        rb = hitBall.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            print("hit!!");
            Destroy(other.gameObject);

            GameObject hit = Instantiate(hitBall);
            hit.transform.position = transform.position;
            rb.AddForce(Camera.main.transform.forward * hitPower);

        }
    }
}
