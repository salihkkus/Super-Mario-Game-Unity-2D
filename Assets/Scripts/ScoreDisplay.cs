using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText; // Reference to the UI text component

    private void Start()
    {
        // Retrieve the player's score from PlayerPrefs
        int playerScore = PlayerPrefs.GetInt("PlayerScore", 0);

        // Update the UI text to display the score
        scoreText.text = "YOUR SCORE : " + playerScore;
    }
}
