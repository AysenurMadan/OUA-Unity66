using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectibleItemController.Instance.Take();
            gameObject.SetActive(false);
            MenuScript.Instance.CoinIndex();
        }

    }
}
