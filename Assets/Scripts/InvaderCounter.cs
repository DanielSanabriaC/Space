using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvaderCounter : MonoBehaviour
{


    public int invaderCount;

    public void EnemyCounter()
    {
        invaderCount++;

        if (invaderCount == 48)
        {
            SceneManager.LoadScene("Win");
        }
    }
    
}
