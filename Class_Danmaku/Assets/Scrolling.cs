using UnityEngine;

public class Scrolling : MonoBehaviour
{
    //Speed at Which the screen Scrolls
    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        //Scroll the Screen Backwards at a set speed
        transform.Translate(0,0, -(Time.deltaTime * speed));
    }
}
