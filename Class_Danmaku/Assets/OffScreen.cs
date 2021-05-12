using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreen : MonoBehaviour
{
    public Transform myObject;
    public GameObject myObjectBody;

    void Start()
    {
        myObjectBody.SetActive(false);
    }

    void Update()
    {
        if(myObject.position.z <= 25)
        {
            myObjectBody.SetActive(true);
        }

        /**
        void OnBecameInvisible()
        {
            myObject.SetActive(false);
        }

        void OnBecameVisible()
        {
            myObject.SetActive(true);
        }
        **/

        Debug.Log(myObjectBody.activeSelf);
    }
}
