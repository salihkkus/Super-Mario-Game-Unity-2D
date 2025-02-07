using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if the player collides with the trigger
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
        }
    }
}
