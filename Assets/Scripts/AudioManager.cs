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
        // Þu anki sahneye göre müzik çal
        UpdateMusicForCurrentScene();
    }

    private void UpdateMusicForCurrentScene()
    {
        switch (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name)
        {
            case "MainMenuScene":
                backgroundMusic.clip = mainMenuMusic;
                break;
            case "BarýþScene":
                backgroundMusic.clip = levelMusic;
                break;
            case "BatuhanScene":
                backgroundMusic.clip = levelMusic;
                break;
            case "BuseScene":
                backgroundMusic.clip = levelMusic;
                break;
            case "BüþraScene":
                backgroundMusic.clip = levelMusic;

                break;
            case "EndGameScene":
                backgroundMusic.clip = celebrityMusic;

                break;
                // Diðer sahne isimleri ve müzikleri
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


