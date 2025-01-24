using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

private void OnTriggerEnter2D(Collider2D other)
{
    if(other.CompareTag("Player"))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

public void Next()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

}