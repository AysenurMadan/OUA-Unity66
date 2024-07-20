using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int totalCollectibles;
    private int collectedItems;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        totalCollectibles = FindObjectsOfType<CollectibleItem>().Length;
    }

    public void CollectItem()
    {
        collectedItems++;
        if (collectedItems >= totalCollectibles)
        {
            // Bir sonraki sahneye geçiþ
            NextLevel();
        }
    }

    private void NextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

}
