using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        // PlayerPrefs'den skoru al
        int playerScore = PlayerPrefs.GetInt("PlayerScore", 0);

        // UI Text'ini güncelle
        scoreText.text = "YOUR SCORE : " + playerScore;
    }
}
