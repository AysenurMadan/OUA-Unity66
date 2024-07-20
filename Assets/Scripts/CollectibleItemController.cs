using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItemController : Singleton<CollectibleItemController>
{
    public List<GameObject> CoinList;
    public int Coin;

    public void Take()
    {
        Coin++;
        Debug.Log(Coin);
    }
    public void List()
    {
        foreach (var item in CoinList)
        {
            item.SetActive(true);
        }
    }
}
