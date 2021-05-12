using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_BulletCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Enemy")
        {
            GameManager.Instance.Score += 10;
            collisionInfo.collider.gameObject.GetComponent<EnemyHP>().HP -= 1;
            Debug.Log("Damage Dealt!");
            Destroy(gameObject);
        }

        if (collisionInfo.collider.tag == "Boss")
        {
            GameManager.Instance.Score += 10;
            collisionInfo.collider.gameObject.GetComponent<EnemyHP>().HP -= 1;
            Destroy(gameObject);
        }
    }
}
