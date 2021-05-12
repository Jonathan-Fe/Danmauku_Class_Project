using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform E_FirePoint;
    public Transform myObject;
    public GameObject E_BulletPrefab;
    public Transform TargetPlayer;

    public float BulletForce = -500f;
    public float FireRate = 2f;
    public float NextFire;
    public float range = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > NextFire && myObject.position.z < 25)
        {
            NextFire = Time.time + FireRate;

            E_Shoot();
        }

    }

    void E_Shoot()
    {
        GameObject bullet = Instantiate(E_BulletPrefab, E_FirePoint.position, E_FirePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
        rb.velocity = new Vector3(0, 0, -20);
        //rb.AddForce(0, 0, BulletForce * Time.deltaTime, ForceMode.VelocityChange);
    }
}
