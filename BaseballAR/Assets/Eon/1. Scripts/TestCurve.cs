using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCurve : MonoBehaviour
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
        float x = Random.Range(-0.4f, 0.4f);
        float y = Random.Range(-0.5f, 0.5f);
        firingAngle = Random.Range(0.0f, 15.0f);

        Target = new Vector3(x, y, 2.94f);

        StartCoroutine(SimulateProjectile());
    }

    // Update is called once per frame
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
