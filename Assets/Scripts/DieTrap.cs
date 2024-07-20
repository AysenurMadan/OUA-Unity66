using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTrap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectibleItemController.Instance.Coin = 0;
            CharacterController.Instance.Destination();
            CollectibleItemController.Instance.List();
        }
    }
}
