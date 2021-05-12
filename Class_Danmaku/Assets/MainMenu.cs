using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scrolling_Stage");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    public void TestRoom()
    {
        Debug.Log("Back to the Lab again.");
        SceneManager.LoadScene("Testing_Room");
    }
}
