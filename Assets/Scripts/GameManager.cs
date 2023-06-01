using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public PlayerController pc;

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
        ballsOnScene = GameObject.FindObjectsOfType<Ball>().Length;
        ScoreText.SetText("Score: " + score);
        RemainingBallsText.SetText("RemainingBalls: " + ballsremaining);
        Winner();
        Loser();
    }

    public void Winner()
    {
        if (score >= 650 && ballsremaining == 0 && ballsOnScene == 2)
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
        if (score <= 649 && ballsremaining == 0 && ballsOnScene == 2)
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
        SceneManager.LoadScene("Plinko");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Plinko");
    }

    public void ToTitle()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
