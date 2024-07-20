using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : Singleton<MainMenu>
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("BarýþScene");
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Oyundan çýkýþ yapýldý.");
    }
}
