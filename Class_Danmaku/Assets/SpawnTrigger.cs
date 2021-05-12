using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public Transform myObject;
    private bool hasTriggered = false;
    public int spawnType = 0;

    public GameObject enemyToSpawn;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform spawnPoint5;

    // Update is called once per frame
    void Update()
    {
        if(myObject.position.z < 25 && hasTriggered == false)
        {
            switch (spawnType)
            {
                case 1:
                    Instantiate(enemyToSpawn, spawnPoint2.position, spawnPoint1.rotation);
                    Debug.Log("Spawn 1 Triggered!");
                    hasTriggered = true;
                    break;

                case 2:
                    Instantiate(enemyToSpawn, spawnPoint1.position, spawnPoint1.rotation);
                    Instantiate(enemyToSpawn, spawnPoint3.position, spawnPoint3.rotation);
                    Debug.Log("Spawn 2 Triggered!");
                    hasTriggered = true;
                    break;

                case 3:
                    Instantiate(enemyToSpawn, spawnPoint1.position, spawnPoint1.rotation);
                    Instantiate(enemyToSpawn, spawnPoint2.position, spawnPoint2.rotation);
                    Instantiate(enemyToSpawn, spawnPoint3.position, spawnPoint3.rotation);
                    Debug.Log("Spawn 3 Triggered!");
                    hasTriggered = true;
                    break;

                case 4:
                    Instantiate(enemyToSpawn, spawnPoint2.position, spawnPoint2.rotation);
                    Debug.Log("Spawn 4 Triggered!");
                    hasTriggered = true;
                    break;

                case 5:
                    Instantiate(enemyToSpawn, spawnPoint4.position, spawnPoint4.rotation);
                    Instantiate(enemyToSpawn, spawnPoint5.position, spawnPoint5.rotation);
                    Debug.Log("Spawn 4 Triggered!");
                    hasTriggered = true;
                    break;

                default:
                    Debug.Log("Spawn Triggered!");
                    hasTriggered = true;
                    break;
            }
        }
    }
}
