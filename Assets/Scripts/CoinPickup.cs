using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinPickup : MonoBehaviour
{

    [SerializeField] AudioClip coinPickUpSFX;
    [SerializeField] int pointsForCoinPickup = 50;

    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerbody = FindObjectOfType<Player>().GetComponent<CapsuleCollider2D>();
        if(collision == playerbody)
        {
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
            AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
