using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContac : MonoBehaviour
{

    public GameObject explosion;
    public GameObject explosionPlayer;

    public int scoreValue;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag( "Limits")) return;

        Instantiate(explosion,transform.position, transform.rotation);
        if (other.CompareTag("Player"))
        {
            
            Instantiate(explosionPlayer, other.transform.position, other.transform.rotation);
            gameManager.GameOver();
        }

        gameManager.addScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject); 
    }
}
