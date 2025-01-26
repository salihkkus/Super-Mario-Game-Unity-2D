using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro; // TextMeshPro kullanımı için gerekli

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clicksound; // Coin sesi
    [SerializeField] private TextMeshProUGUI coinText; // UI Text referansı
    private int count = 0; // Toplanan coin sayısı

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            // Coin sayısını artır ve ses çal
            count++;
            Debug.Log("Toplanan Coin: " + count);
            AudioSource.PlayClipAtPoint(clicksound, other.transform.position);

            // UI'yı güncelle
            UpdateCoinText();

            // Coin'i yok et
            Destroy(other.gameObject);
        }
    }

    // Coin sayısını UI'da güncelleyen fonksiyon
    private void UpdateCoinText()
    {
        coinText.text = "Coins: " + count;
    }
}
