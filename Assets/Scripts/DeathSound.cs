using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : MonoBehaviour
{
    public AudioSource deathSound; // Ölüm sesini kontrol edecek deðiþken

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Ölüm sesini çal
            deathSound.Play();

        }
    }
}
