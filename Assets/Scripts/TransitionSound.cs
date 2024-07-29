using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionSound : MonoBehaviour
{
    public AudioSource transitionSound; // Ölüm sesini kontrol edecek deðiþken

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Ölüm sesini çal
            transitionSound.Play();

        }
    }
}