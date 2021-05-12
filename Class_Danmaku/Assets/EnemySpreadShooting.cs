using UnityEngine;

public class EnemySpreadShooting : MonoBehaviour
{
    public Transform E_FirePoint;
    public Transform myObject;
    public GameObject E_BulletPrefab;
    public Transform TargetPlayer;
    private Rigidbody enR;

    public float BulletForce = -500f;
    public float FireRate = 2f;
    public float NextFire;
    public float maxSpeed = 10f;
    public float range = 20f;

    void Start()
    {
        enR = this.GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        TargetPlayer = Player.transform;

        if (Time.time > NextFire && myObject.position.z < 25)
        {

            NextFire = Time.time + FireRate;

            //transform.LookAt(TargetPlayer.position);

            E_Shoot();
        }

        /**
        Vector3 direction = TargetPlayer.position - transform.position;
        Debug.Log(direction);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        enR.rotation = Quaternion.Euler(0,angle,0);
        */
    }

    void E_Shoot()
    {
        GameObject bullet = Instantiate(E_BulletPrefab, E_FirePoint.position, E_FirePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());

        //rb.AddForce(0, 0, BulletForce * Time.deltaTime, ForceMode.VelocityChange);
        rb.velocity = (TargetPlayer.position - transform.position) / (BulletForce * Time.deltaTime);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
    }
}
