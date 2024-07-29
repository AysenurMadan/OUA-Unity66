using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : MonoBehaviour
{
    public AudioSource deathSound; // �l�m sesini kontrol edecek de�i�ken

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �l�m sesini �al
            deathSound.Play();

        }
    }
}
