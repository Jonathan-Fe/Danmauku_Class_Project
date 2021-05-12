using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombing : MonoBehaviour
{
    public float bombRadius = 10f;

    public float FireRate = 5f;
    public float NextFire;

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.Bombs == 0)
        {
            Debug.Log("You're out of Bombs Buddy, gotta get gutsy!");
        }

        if (Input.GetKey("x") && Time.time > NextFire && GameManager.Instance.Bombs > 0)
        {

            NextFire = Time.time + FireRate;

            Debug.Log("Panic Button!");
            Bomb();
        }
    }

    GameObject[] OnScreen;

    void Bomb()
    {
        GameManager.Instance.Bombs -= 1;

        GameObject[] bullets = GameObject.FindGameObjectsWithTag("E_Bullet");
        foreach (GameObject bullet in bullets)
        {
            if (bombRadius >= Vector3.Distance(transform.position, bullet.transform.position))
            {
                GameObject.Destroy(bullet);
                GameManager.Instance.Score += 10;
            }
        }

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
                if (bombRadius >= Vector3.Distance(transform.position, enemy.transform.position))
                {
                    GameObject.Destroy(enemy);
                GameManager.Instance.Score += 50;
            }
        }

        GameObject[] bosses = GameObject.FindGameObjectsWithTag("Boss");
        foreach (GameObject boss in bosses)
        {
            if (bombRadius >= Vector3.Distance(transform.position, boss.transform.position))
            {
                gameObject.GetComponent<EnemyHP>().HP -= 20;
                GameManager.Instance.Score += 50;
            }
        }

    }
}
