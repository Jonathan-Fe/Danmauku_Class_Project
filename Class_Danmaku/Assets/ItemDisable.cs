using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisable : MonoBehaviour
{
    private GameObject ItemActivatorObject;
    private ItemActivator activationScript;

    // Start is called before the first frame update
    void Start()
    {
        ItemActivatorObject = GameObject.Find("ItemActivatorObject");
        activationScript = ItemActivatorObject.GetComponent<ItemActivator>();

        StartCoroutine("AddToList");

    }

    IEnumerator AddToList()
    {
        yield return new WaitForSeconds(0.01f);

        activationScript.activatorItems.Add(new ActivatorItem { item = this.gameObject, itemPos = transform.position });
    }
}
