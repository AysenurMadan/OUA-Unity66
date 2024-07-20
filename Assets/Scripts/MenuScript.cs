using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuScript : Singleton<MenuScript>
{
    public TextMeshProUGUI CoinPoint;
    // Start is called before the first frame update
    public void CoinIndex()
    {
        CoinPoint.text = "Element: " + CollectibleItemController.Instance.Coin;
    }
}
