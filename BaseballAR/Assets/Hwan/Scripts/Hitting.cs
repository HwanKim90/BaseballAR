using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitting : MonoBehaviour
{
    public static float stayTime;
    public static float xHitPower;
    public static float yHitPower;
    public static float zHitPower;

    public static Hitting instance;
    public GameObject hitBall;
    
    float power = 0.01f;
    BoxCollider bc;
    
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    void Update()
    {
        //// 임시 Box Collider false;
        //if (Input.GetMouseButtonDown(0))
        //{
        //    bc.enabled = false;
        //}

        //if (Input.GetMouseButtonDown(1))
        //{
        //    bc.enabled = true;
        //    //Swing(-1000, 1000, 700);
        //    StartCoroutine(SwingTiming());
        //}
    }

    public void OnClickSwing()
    {
        bc.enabled = true;
        
        if (StrikeZoneHelper.isStrike)
        {
            print("스트라이크존통과" + bc.enabled);
            StartCoroutine(SwingTiming());
        }
        else
        {
            bc.enabled = false;
            print("볼" + bc.enabled);
        }

    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            xHitPower = FindXHitPower(other);
            yHitPower = FindYHitPower(other);
            zHitPower = FindZHitPower(other);

            print(xHitPower + " " + yHitPower + " " + zHitPower);
        }
    }

    IEnumerator SwingTiming()
    {
        yield return new WaitForSeconds(0.5f);
        Swing(xHitPower, yHitPower, zHitPower);
    }

    public void Swing(float xHitPower, float yHitPower, float zHitPower)
    {
        GameObject hit = Instantiate(hitBall);
        hit.transform.position = transform.position;
        if (xHitPower == 0 && yHitPower == 0 && zHitPower == 0) Destroy(hit);

        Rigidbody rb = hit.GetComponent<Rigidbody>();
        
        rb.AddRelativeForce(new Vector3(xHitPower, yHitPower, zHitPower));
    }

    

    float FindXHitPower(Collider other)
    {
        float xHitPower = power;
        Vector3 xPos = other.GetComponent<Transform>().transform.position;
        if (xPos.x == 0)
        {
            xHitPower = 0;
        }
        else 
        {
            xHitPower *= xPos.x * 10; 
        }
        
        return xHitPower;

    }
    float FindYHitPower(Collider other)

    {
        float yHitPower = power;
        Vector3 yPos = other.GetComponent<Transform>().transform.position;
        if (yPos.y <= 0.15 && yPos.y >= -0.15)
        {
            yHitPower = power * 0.2f;
        }
        else
        {
            yHitPower *= yPos.y * 0.15f;

        }
        return Mathf.Abs(yHitPower);
    }

    float FindZHitPower(Collider other)
    {
        float zHitPower = power;
        Vector3 zPos = other.GetComponent<Transform>().transform.position;
        zHitPower *= zPos.z * 0.01f;
        return zHitPower;
    }

}
