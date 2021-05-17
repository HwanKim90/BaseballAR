using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceMove : MonoBehaviour
{
    public float speed = 200f;
    
    float canvasSizeX;
    float canvasSizeY;
    float radius;

    Vector3 dirX = Vector3.right;
    Vector3 dirY = Vector3.up;

    void Start()
    {
        radius = GetComponent<RectTransform>().rect.width / 2;
        //print(radius);
    }

    void Update()
    {
        GetCanvasSize();
        BounceCanvas();
        BallMove();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("UIcolObj"))
        {
            dirX *= -1;
        }
    }

    void BallMove()
    {
        transform.position += dirX * speed * Time.deltaTime;
        transform.position += dirY * speed * Time.deltaTime;
    }

    void GetCanvasSize()
    {
        canvasSizeX = GetComponentInParent<Canvas>().renderingDisplaySize.x;
        canvasSizeY = GetComponentInParent<Canvas>().renderingDisplaySize.y;
        //print(canvasSizeX + " " + canvasSizeY);
    }

    void BounceCanvas()
    {
        float minX = radius;
        float maxX = canvasSizeX - radius;
        float minY = radius;
        float maxY = canvasSizeY - radius;

        if (minX >= transform.position.x || maxX <= transform.position.x)
        {
            dirX *= -1;
            print("x충돌");
        }
        else if (minY >= transform.position.y || maxY <= transform.position.y)
        {
            dirY *= -1;
            print("y충돌");
        }
    }
}
