using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject P_prefab;
    public Transform RespawnPoint;
    public float RespawnTime = 2f;
    public float NextSpawn;

    private bool isInvincible = false;
    public float invincibilityDuration = 2;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "E_Bullet")
        {
            if (isInvincible) return;
       
            GameManager.Instance.Lives -= 1;
            GameManager.Instance.Score -= 50;
            Debug.Log("Life Lost!");

            Destroy(collisionInfo.collider.gameObject);
            if (GameManager.Instance.Lives == 0)
            {
                FindObjectOfType<GameManager>().EndGame();
                Destroy(gameObject);
            }

            StartCoroutine(BecomeTemporarilyInvincible());
            transform.position = RespawnPoint.position;
        }

        if (collisionInfo.collider.tag == "Low_Obstacle")
        {
            if (isInvincible) return;

            GameManager.Instance.Lives -= 1;
            GameManager.Instance.Score -= 50;
            Debug.Log("Life Lost!");
            
            if (GameManager.Instance.Lives == 0)
            {
                FindObjectOfType<GameManager>().EndGame();
                Destroy(gameObject);
            }

            StartCoroutine(BecomeTemporarilyInvincible());
            transform.position = RespawnPoint.position;
        }

        if (collisionInfo.collider.tag == "Enemy")
        {
            if (isInvincible) return;

            GameManager.Instance.Lives -= 1;
            GameManager.Instance.Score -= 50;
            Debug.Log("Life Lost!");
            
            Destroy(collisionInfo.collider.gameObject);
            if (GameManager.Instance.Lives == 0)
            {
                FindObjectOfType<GameManager>().EndGame();
                Destroy(gameObject);
            }

            StartCoroutine(BecomeTemporarilyInvincible());
            transform.position = RespawnPoint.position;
        }

        if (collisionInfo.collider.tag == "Boss")
        {
            if (isInvincible) return;

            GameManager.Instance.Lives -= 1;
            GameManager.Instance.Score -= 50;
            Debug.Log("Life Lost!");
            

            if (GameManager.Instance.Lives == 0)
            {
                FindObjectOfType<GameManager>().EndGame();
                Destroy(gameObject);
            }

            StartCoroutine(BecomeTemporarilyInvincible());
            transform.position = RespawnPoint.position;
        }

        if (collisionInfo.collider.tag == "Bomb")
        {
            Destroy(collisionInfo.collider.gameObject);
            GameManager.Instance.Bombs += 1;
            GameManager.Instance.Score += 750;
            Debug.Log("+1 Bomb!");

        }

        if (collisionInfo.collider.tag == "Life")
        {
            Destroy(collisionInfo.collider.gameObject);
            GameManager.Instance.Lives += 1;
            GameManager.Instance.Score += 1000;
            Debug.Log("EXTEND!");
        }

    }

    private IEnumerator BecomeTemporarilyInvincible()
    {
        Debug.Log("Player is invincible!");
        isInvincible = true;

        yield return new WaitForSeconds(invincibilityDuration);

        isInvincible = false;
        Debug.Log("Player is no longer invincible!");
    }
}
