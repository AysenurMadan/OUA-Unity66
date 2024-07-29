using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // "MainMenu" sahnesinin ad�. Sahnenizin ismi farkl�ysa buray� g�ncelleyin.
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Oyundan ��k�� yap�ld�.");
    }
}
