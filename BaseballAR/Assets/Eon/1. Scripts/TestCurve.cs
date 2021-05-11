using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCurve : MonoBehaviour
{
    public GameObject Target;
    public float firingAngle;
    public float gravity = 9.8f;

    public Transform Projectile;
    private Transform myTransform;

    Vector3 isTarget;

    private void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        Target = GameObject.Find("TargetTest");

        firingAngle = Random.Range(15.0f, 30.0f);
        isTarget = Target.transform.position; //- new Vector3(0.2f, 0, 0);
        StartCoroutine(SimulateProjectile());
    }


    IEnumerator SimulateProjectile()
    {

        Projectile.position = myTransform.position + new Vector3(0, 0.0f, 0);

        float target_Distance = Vector3.Distance(Projectile.position, isTarget);

        float projectile_Velocity = target_Distance / (Mathf.Sin(2 * firingAngle * Mathf.Deg2Rad) / gravity);

        float Vx = Mathf.Sqrt(projectile_Velocity) * Mathf.Cos(firingAngle * Mathf.Deg2Rad);
        float Vy = Mathf.Sqrt(projectile_Velocity) * Mathf.Sin(firingAngle * Mathf.Deg2Rad);

        float flightDuration = target_Distance / Vx;

        Projectile.rotation = Quaternion.LookRotation(isTarget - Projectile.position);

        float elapse_time = 0;

        while (elapse_time < flightDuration)
        {
            Projectile.Translate(0, (Vy - (gravity * elapse_time)) * Time.deltaTime, Vx * Time.deltaTime);

            elapse_time += Time.deltaTime;

            yield return null;
        }

    }
}
