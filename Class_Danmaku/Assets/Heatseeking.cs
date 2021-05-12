using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heatseeking : MonoBehaviour
{
    private GameObject target;
    private Vector3 playerPos;
    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform.position);

        playerPos = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);



        transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
    }
}
