using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // "MainMenu" sahnesinin adý. Sahnenizin ismi farklýysa burayý güncelleyin.
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Oyundan çýkýþ yapýldý.");
    }
}
