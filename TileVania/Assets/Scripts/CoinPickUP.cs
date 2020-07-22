using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUP : MonoBehaviour
{
    [SerializeField] AudioClip coinPickUpSFX;
    [SerializeField] int coinValue = 100;
    private void OnTriggerEnter2D(Collider2D other)
    {
        FindObjectOfType<GameSession>().AddToScore(coinValue);
        AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
