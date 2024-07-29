using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public AudioSource coinSound; // Coin toplama sesini kontrol edecek de�i�ken

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Coin toplama sesini �al
            if (coinSound != null)
            {
                coinSound.Play();
            }
        }
    }
}

