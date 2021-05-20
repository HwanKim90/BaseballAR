using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingRandom : MonoBehaviour
{   
    public GameObject hitBalls;
    public GameObject hitPos;
    public GameObject hitEftFactory;

    public static float xHitPower;
    public float yHitPower;
    public float zHitPower;

    BoxCollider bc;
    bool isSettingPower;

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

        yield return new WaitForSeconds(0.05f);
        bc.enabled = false;
        DefaultHitPower();
    }

    void SetHitPower()
    {
        xHitPower = Random.Range(-3f, 3f);
        yHitPower = Random.Range(2f, 2.5f);
        zHitPower = Random.Range(2f, 2.5f);
        isSettingPower = true;
    }

    void DefaultHitPower()
    {
        xHitPower = 0;
        yHitPower = 0;
        zHitPower = 0;
        isSettingPower = false;
    }

    void Shoot()
    {
        
        GameObject hitBall = Instantiate(hitBalls);
        //ScoreManager.instance.AddScore(10);
        hitBall.transform.SetPositionAndRotation(hitPos.transform.position, hitPos.transform.rotation);
        Rigidbody rb = hitBall.GetComponent<Rigidbody>();
        rb.AddRelativeForce(xHitPower, yHitPower, zHitPower, ForceMode.VelocityChange);
        
        if (xHitPower == 0 && yHitPower == 0 && zHitPower == 0) Destroy(hitBall);
        if (isSettingPower) HitEft();

    }

    void HitEft()
    {
        GameObject hitEft = Instantiate(hitEftFactory);
        hitEft.transform.SetPositionAndRotation(hitPos.transform.position, hitPos.transform.rotation);
        Destroy(hitEft, 0.5f);
    }
}


