using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource backgroundMusic;
    public AudioClip mainMenuMusic;
    public AudioClip levelMusic;
    public AudioClip celebrityMusic;
    private bool isMusicPlaying = true;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // �u anki sahneye g�re m�zik �al
        UpdateMusicForCurrentScene();
    }

    private void UpdateMusicForCurrentScene()
    {
        switch (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name)
        {
            case "MainMenuScene":
                backgroundMusic.clip = mainMenuMusic;
                break;
            case "Bar��Scene":
                backgroundMusic.clip = levelMusic;
                break;
            case "BatuhanScene":
                backgroundMusic.clip = levelMusic;
                break;
            case "BuseScene":
                backgroundMusic.clip = levelMusic;
                break;
            case "B��raScene":
                backgroundMusic.clip = levelMusic;

                break;
            case "EndGameScene":
                backgroundMusic.clip = celebrityMusic;

                break;
                // Di�er sahne isimleri ve m�zikleri
        }
        backgroundMusic.Play();
    }

    public void ToggleMusic()
    {
        isMusicPlaying = !isMusicPlaying;
        if (isMusicPlaying)
        {
            backgroundMusic.Play();
        }
        else
        {
            backgroundMusic.Pause();
        }
    }

    public void SetMusicVolume(float volume)
    {
        backgroundMusic.volume = volume;
    }
}


