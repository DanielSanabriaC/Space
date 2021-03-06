using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderOver : MonoBehaviour
{

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")){

            gameManager.GameOver();
        }
    }
}
