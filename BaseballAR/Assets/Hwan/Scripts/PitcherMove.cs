using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitcherMove : MonoBehaviour
{

    public float moveSpeed = 5;

    public GameObject ball;

    public Transform releasePoint;
    
    void Update()
    {
        Move();   

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject pitch = Instantiate(ball);
            pitch.transform.position = releasePoint.position;
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, y, 0);
        dir.Normalize();

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
