using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void MainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void MainBack()
    {
        SceneManager.LoadScene("SelectorScreen");
    }

    public void MainCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    


    
}
