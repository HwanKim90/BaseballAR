using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Vector3 Target;
    public float firingAngle;
    public float gravity = 9.8f;

    public Transform Projectile;
    private Transform myTransform;

    private void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(12.0f, 18.0f);
        firingAngle = Random.Range(15.0f, 75.0f);

        Target = new Vector3(x, -0.5f, z);  

        StartCoroutine(SimulateProjectile());
    }

    IEnumerator SimulateProjectile()
    {
        //yield return new WaitForSeconds(1.5f);

        Projectile.position = myTransform.position + new Vector3(0, 0.0f, 0);

        float target_Distance = Vector3.Distance(Projectile.position, Target);

        float projectile_Velocity = target_Distance / (Mathf.Sin(2 * firingAngle * Mathf.Deg2Rad) / gravity);

        float Vx = Mathf.Sqrt(projectile_Velocity) * Mathf.Cos(firingAngle * Mathf.Deg2Rad);
        float Vy = Mathf.Sqrt(projectile_Velocity) * Mathf.Sin(firingAngle * Mathf.Deg2Rad);

        float flightDuration = target_Distance / Vx;

        Projectile.rotation = Quaternion.LookRotation(Target - Projectile.position);

        float elapse_time = 0;

        while (elapse_time < flightDuration)
        {
            Projectile.Translate(0, (Vy - (gravity * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

            elapse_time += Time.deltaTime;

            yield return null;
        }

        Destroy(gameObject, 3.5f);
    }
}
