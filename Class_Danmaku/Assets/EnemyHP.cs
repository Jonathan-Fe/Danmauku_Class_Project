using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int HP = 1;
    public int Score = 100;
    public Transform myObject;

    public bool enemyHasDrop = false;
    public GameObject bomb;
    public GameObject life;
    public int dropChance = 4;

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            GameManager.Instance.Score += Score;
            if(tag == "Boss")
            {
                FindObjectOfType<GameManager>().GameWin();
            }

            int num = Random.Range(1, 11);

            if(enemyHasDrop == true && num <= dropChance)
            {
                if(num == dropChance)
                {
                    Instantiate(life, myObject.position, myObject.rotation);
                }
                else
                {
                    Instantiate(bomb, myObject.position, myObject.rotation);
                }

            }

            Destroy(gameObject);
        }

    }
}
