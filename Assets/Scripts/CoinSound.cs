using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public AudioSource coinSound; // Coin toplama sesini kontrol edecek deðiþken

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Coin toplama sesini çal
            if (coinSound != null)
            {
                coinSound.Play();
            }
        }
    }
}

