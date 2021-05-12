using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance == null) { Instance = this; } else if (Instance != this) { Destroy(this); }
        //DontDestroyOnLoad(gameObject);
    }

    public int Score = 0;
    public int Lives = 3;
    public int Bombs = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

        if (Lives <= 0)
        {
            EndGame();
        }


    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        Debug.Log("GAME OVER");
        SceneManager.LoadScene("GameOver");
    }

    public void GameWin()
    {
        Debug.Log("VICTORY!");
        SceneManager.LoadScene("GameWin");
    }
}
