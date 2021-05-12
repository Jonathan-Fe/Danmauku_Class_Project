using UnityEngine;
using UnityEngine.UI;

public class BombText : MonoBehaviour
{
    public Text bombText;

    // Update is called once per frame
    void Update()
    {
        bombText.text = "Bombs: " + GameManager.Instance.Bombs.ToString();
    }
}
