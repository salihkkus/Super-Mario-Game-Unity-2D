using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{

private int count = 0;

private void  OnTriggerEnter2D(Collider2D other)
{

if(other.gameObject.CompareTag("Collectible"))
{
    Debug.Log(count);
    count++;
    Destroy(other.gameObject);
}

}

}
