using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip clicksound; // Coin collection sound effect
    [SerializeField] private TextMeshProUGUI coinText; // UI Text reference for displaying coins
    private int count = 0; // Number of collected coins

    private void Start()
    {
        // Reset the score when a new game starts
        PlayerPrefs.SetInt("PlayerScore", 0);
        PlayerPrefs.Save();

        // Initialize the coin count to zero
        count = 0;
        UpdateCoinText(); // Update the UI
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible")) // Check if the collided object is a collectible
        {
            // Increase the coin count and play the sound effect
            count++;
            Debug.Log("Collected Coin: " + count);
            AudioSource.PlayClipAtPoint(clicksound, other.transform.position, 10000f);

            // Save the score using PlayerPrefs
            PlayerPrefs.SetInt("PlayerScore", count);
            PlayerPrefs.Save();

            // Update the UI
            UpdateCoinText();

            // Destroy the collected coin object
            Destroy(other.gameObject);
        }
    }

    private void UpdateCoinText()
    {
        // Update the text to show the current coin count
        coinText.text = "Coins : " + count + " / 22 ";
    }
}
