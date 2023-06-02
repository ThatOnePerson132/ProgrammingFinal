using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public PlayerController pc;

    public bool isGameActive = false;

    public float ballsremaining;
    public TextMeshProUGUI RemainingBallsText;

    public float score;
    public TextMeshProUGUI ScoreText;

    public Scorezone[] sz;
    public int ballsOnScene;

    // Start is called before the first frame update
    void Start()
    {
        sz = GameObject.FindObjectsOfType<Scorezone>();
        player = GameObject.Find("Player");
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //BUTTONS
        if(Input.GetButtonDown("Fire2") && isGameActive == false)
        {
            StartGame();
        }

        if (Input.GetButtonDown("Fire3") && isGameActive == false)
        {
            ToTitle();
        }

        if (Input.GetButtonDown("Fire4") && isGameActive == false)
        {
            Quit();
        }


        if (isGameActive == true)
        {
         ballsOnScene = GameObject.FindObjectsOfType<Ball>().Length;
         ScoreText.SetText("Score: " + score);
         RemainingBallsText.SetText("RemainingBalls: " + ballsremaining);
        }


         Winner();
         Loser();
        





    }

    public void Winner()
    {
        if (score >= 750 && ballsremaining == 0 && ballsOnScene == 2)
        {
            StartCoroutine(LoadWin());
        }

    }

    IEnumerator LoadWin()
    {
        
            
        yield return new WaitForSeconds(5);  
        SceneManager.LoadScene("Winner");
        
    }

    public void Loser()
    {
        if (score <= 749 && ballsremaining == 0 && ballsOnScene == 2)
        {
            StartCoroutine(LoadLose());
        }

    }

    IEnumerator LoadLose()
    {

        
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("Loser");
        
    }

    public void StartGame()
    {
        isGameActive = true;
        SceneManager.LoadScene("Plinko");
        isGameActive = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Plinko");
        isGameActive = true;
    }

    public void ToTitle()
    {
        isGameActive = false;
        SceneManager.LoadScene("TitleScreen");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
