using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject[] invaiderEnemys;

    public Vector3 invaderP;
    public int amountInvader;

    private int score;
    public Text scoreText;

    public Text restartText;
    public Text gameOverText;
    
    public bool gameOver;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
       // restart = false;
        gameOver = false;
        gameOverText.gameObject.SetActive(false);
        restartText.gameObject.SetActive(false);
        score = 0;
        meshLevel();
        updateScore();
    }

   void meshLevel()
    {

        
        for (int x = 0; x < amountInvader; x++)
        {
            GameObject invaiderEnemy = invaiderEnemys[Random.Range(0,3)];
            Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y, invaderP.z);
           Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
             invaderP.x +=4;
            
        }
        invaderP.x = -8;

        for (int x = 0; x < amountInvader; x++)
        {
            GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
            Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y -2, invaderP.z);
           Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
            invaderP.x += 4;

        }
        
        invaderP.x = -8;

        for (int x = 0; x < amountInvader; x++)
        {
            GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
            Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y - 4, invaderP.z);
           Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
             invaderP.x += 4;

        }

        invaderP.x = -8;
        for (int x = 0; x < amountInvader; x++)
        {
            GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
            Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y - 6, invaderP.z);
           Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
            invaderP.x += 4;
        }
        invaderP.x = -8;
        for (int x = 0; x < amountInvader; x++)
        {
            GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
            Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y - 8, invaderP.z);
           Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
            invaderP.x += 4;

        }  
    }


    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            restartText.gameObject.SetActive(true);
          
        }
        
    }
    public void addScore(int value)
    {
        score += value;
        updateScore();
        if (score == 40 || score == 41)
        {
            invaderP.x = -6;
            for (int x = 0; x < amountInvader; x++)
            {
                GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
                Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y, invaderP.z);
               Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
                invaderP.x += 4;

            }
            invaderP.x = -8;

            for (int x = 0; x < amountInvader; x++)
            {
                GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
                Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y - 2, invaderP.z);
               Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
                invaderP.x += 4;

            }

            invaderP.x = -6;

            for (int x = 0; x < amountInvader; x++)
            {
                GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
                Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y - 4, invaderP.z);
               Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
                invaderP.x += 4;

            }

            invaderP.x = -8;
            for (int x = 0; x < amountInvader; x++)
            {
                GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
                Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y - 6, invaderP.z);
               Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
                invaderP.x += 4;
            }
            invaderP.x = -6;
            for (int x = 0; x < amountInvader; x++)
            {
                GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
                Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y - 8, invaderP.z);
              Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
                invaderP.x += 4;

            }
            invaderP.x = -6;
            for (int x = 0; x < amountInvader; x++)
            {
                GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
                Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y +2, invaderP.z);
                Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
                invaderP.x += 4;

            }
            invaderP.x = -6;
            for (int x = 0; x < amountInvader; x++)
            {
                GameObject invaiderEnemy = invaiderEnemys[Random.Range(0, 3)];
                Vector3 InvaiderPosition = new Vector3(invaderP.x, invaderP.y +4, invaderP.z);
                Instantiate(invaiderEnemy, InvaiderPosition, Quaternion.identity);
                invaderP.x += 4;

            }
        }

    }

   public  void updateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {

        StartCoroutine(GameOverCoroutine());
        
    }

    public IEnumerator GameOverCoroutine()
    {
        gameOverText.gameObject.SetActive(true);
        gameOver = true;
       
        
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameOver");
    }
}
