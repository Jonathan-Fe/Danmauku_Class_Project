using UnityEngine;

public class E_BulletSpawn : MonoBehaviour
{

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (!(collisionInfo.collider.tag == "E_Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
