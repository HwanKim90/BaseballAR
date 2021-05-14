using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingRandom : MonoBehaviour
{   
    public GameObject hitBalls;
    public GameObject hitPos;

    
    public static float xHitPower;
    public float yHitPower;
    public float zHitPower;

    BoxCollider bc;

    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SetHitPower();
            ArrowBonusScore.instance.SetArrowScore();
           
        }
    }

    public void OnClickSwing()
    {
        bc.enabled = true;
        StartCoroutine(SwingTiming());
    }

    IEnumerator SwingTiming()
    {
        yield return new WaitForSeconds(0.5f);
        Shoot();
        yield return new WaitForSeconds(0.7f);
        bc.enabled = false;
        DefaultHitPower();
    }

    void SetHitPower()
    {
        xHitPower = Random.Range(-300f, 300f);
        yHitPower = Random.Range(150f, 250f);
        zHitPower = Random.Range(200f, 400f);
    }

    void DefaultHitPower()
    {
        xHitPower = 0;
        yHitPower = 0;
        zHitPower = 0;
    }

    void Shoot()
    {
        GameObject hitBall = Instantiate(hitBalls);
        hitBall.transform.SetPositionAndRotation(hitPos.transform.position, hitPos.transform.rotation);
        Rigidbody rb = hitBall.GetComponent<Rigidbody>();
        rb.AddRelativeForce(xHitPower, yHitPower, zHitPower, ForceMode.Force);
        
        if (xHitPower == 0 && yHitPower == 0 && zHitPower == 0) Destroy(hitBall);
        
    }
}


