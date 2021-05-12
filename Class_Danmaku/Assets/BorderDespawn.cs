using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderDespawn : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Enemy")
        {
            Destroy(collisionInfo.collider.gameObject);
        }

        if (collisionInfo.collider.tag == "E_Bullet")
        {
            Destroy(collisionInfo.collider.gameObject);
        }

        if (collisionInfo.collider.tag == "PickUp")
        {
            Destroy(collisionInfo.collider.gameObject);
        }

        if (collisionInfo.collider.tag == "Low_Obstacle")
        {
            Destroy(collisionInfo.collider.gameObject);
        }

        if (collisionInfo.collider.tag == "P_Bullet")
        {
            Destroy(collisionInfo.collider.gameObject);
        }
    }
}
