using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int Damage;
    public float Range;
    public float FireRate;

    private float nextFireTime;

    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            // gérer le trigger
            nextFireTime = Time.time + 1f / FireRate;
        }
    }

}
