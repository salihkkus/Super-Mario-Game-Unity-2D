using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clicksound; // Coin sesi
    [SerializeField] private TextMeshProUGUI coinText; // UI Text referansı
    private int count = 0; // Toplanan coin sayısı

    private void Start()
    {
        // Yeni oyun başladığında skoru sıfırla
        PlayerPrefs.SetInt("PlayerScore", 0);
        PlayerPrefs.Save();

        // Skoru sıfır olarak başlat
        count = 0;
        UpdateCoinText();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            // Coin sayısını artır ve ses çal
            count++;
            Debug.Log("Toplanan Coin: " + count);
            AudioSource.PlayClipAtPoint(clicksound, other.transform.position);

            // Skoru PlayerPrefs ile kaydet
            PlayerPrefs.SetInt("PlayerScore", count);
            PlayerPrefs.Save();

            // UI'yı güncelle
            UpdateCoinText();

            // Coin'i yok et
            Destroy(other.gameObject);
        }
    }

    private void UpdateCoinText()
    {
        coinText.text = "Coins : " + count + " / 22 ";
    }
}
