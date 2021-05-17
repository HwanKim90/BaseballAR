using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    public static Vector3 directionX = Vector3.right;
    public static Vector3 directionY = Vector3.up;
    public float moveSpeed = 10f;
    
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += directionX * moveSpeed * Time.deltaTime;
        transform.position += directionY * moveSpeed * Time.deltaTime;
    }
}
