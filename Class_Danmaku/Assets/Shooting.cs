using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject P_BulletPrefab;

    public float BulletForce = 2000f;
    public float FireRate = 1f;
    public float NextFire;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("z") && Time.time > NextFire)
        {

            NextFire = Time.time + FireRate;

            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(P_BulletPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
        rb.velocity = new Vector3(0, 0, 30);
        //rb.AddForce(0, 0, BulletForce * Time.deltaTime, ForceMode.VelocityChange);
    }
}
