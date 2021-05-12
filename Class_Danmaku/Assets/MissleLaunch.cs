using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleLaunch : MonoBehaviour
{
    public Transform E_FirePoint;
    public Transform myObject;
    public Transform TargetPlayer;
    public GameObject Missle;

    public float FireRate = 6f;
    public float NextFire;
    public float range = 20f;

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        TargetPlayer = Player.transform;

        if (Time.time > NextFire && myObject.position.z < 25)
        {

            NextFire = Time.time + FireRate;

            E_Shoot();
        }

    }

    void E_Shoot()
    {
        GameObject rocket = Instantiate(Missle, E_FirePoint.position, E_FirePoint.rotation);
        Rigidbody rb = rocket.GetComponent<Rigidbody>();
        Physics.IgnoreCollision(rocket.GetComponent<Collider>(), GetComponent<Collider>());
    }
}
