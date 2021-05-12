using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Refers directly to the Player Object
    public Rigidbody rb;

    //Base Forward Force
    public float ForwardForce = 500f;

    //Base Sideways Force
    public float SidewaysForce = 500f;

    //Vertical Force
    public float VerticalForce = 500f;

    // Update is called once per frame
    void Update()
    {
        
        //Hold Shift for Focused Movement
        if (Input.GetKey("left shift"))
        {
            ForwardForce = 40;
            SidewaysForce = 40;
        }

        //When Shift is Released, return Movement Speed to normal
        if (Input.GetKey(KeyCode.LeftShift) == false)
        {
            ForwardForce = 100;
            SidewaysForce = 100;
        }
        
        //Move Right
        if (Input.GetKey("right"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //Move Left
        if (Input.GetKey("left"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //Move Forward
        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        //Move Backwards
        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -ForwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        //Move Between Layers
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (rb.position.y <= 3f)
            {
                transform.position = new Vector3(rb.position.x, 6f, rb.position.z);
                //rb.AddForce(0, VerticalForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
            if (rb.position.y >= 6f || rb.position.y > 3f)
            {
                transform.position = new Vector3(rb.position.x, 3f, rb.position.z);
                //rb.AddForce(0, -VerticalForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }
    }
}
