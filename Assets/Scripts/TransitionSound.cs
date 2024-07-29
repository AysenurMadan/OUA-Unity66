using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionSound : MonoBehaviour
{
    public AudioSource transitionSound; // �l�m sesini kontrol edecek de�i�ken

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �l�m sesini �al
            transitionSound.Play();

        }
    }
}