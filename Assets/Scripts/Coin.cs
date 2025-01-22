using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{

[SerializeField] private AudioClip clicksound;
private int count = 0;

private void  OnTriggerEnter2D(Collider2D other)
{

if(other.gameObject.CompareTag("Collectible"))
{
    Debug.Log(count);
    AudioSource.PlayClipAtPoint(clicksound, other.transform.position);
    count++;
    Destroy(other.gameObject);
}

}

}
