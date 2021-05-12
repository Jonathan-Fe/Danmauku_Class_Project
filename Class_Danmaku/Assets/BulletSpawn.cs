using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (!(collisionInfo.collider.tag == "P_Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
