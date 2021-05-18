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
            AudioSource audio = gameObject.GetComponent<AudioSource>();
            audio.Play();
            ArrowBonusScore.instance.SetArrowScore();
            ComboBonusScore.hitCnt++;
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

        yield return new WaitForSeconds(0.1f);
        bc.enabled = false;
        DefaultHitPower();
    }

    void SetHitPower()
    {
        xHitPower = Random.Range(-2f, 2f);
        yHitPower = Random.Range(2f, 3f);
        zHitPower = Random.Range(1f, 1.5f);
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
        //ScoreManager.instance.AddScore(10);
        hitBall.transform.SetPositionAndRotation(hitPos.transform.position, hitPos.transform.rotation);
        Rigidbody rb = hitBall.GetComponent<Rigidbody>();
        rb.AddRelativeForce(xHitPower, yHitPower, zHitPower, ForceMode.VelocityChange);
        
        if (xHitPower == 0 && yHitPower == 0 && zHitPower == 0) Destroy(hitBall);
        
    }
}


