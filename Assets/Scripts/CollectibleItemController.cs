using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleItemController : Singleton<CollectibleItemController>
{
    public List<GameObject> CoinList;
    public int Coin;
    public string nextSceneName;
    public bool transition;

    public void Take()
    {
        Coin++;
        Debug.Log(Coin);

        if (Coin>=4) 
        {
            transition = true;
        }
    }
    public void List()
    {
        foreach (var item in CoinList)
        {
            item.SetActive(true);
        }
    }

   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")&& transition==true)
        {
            ChangeScene();
        }

    }
    private void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
