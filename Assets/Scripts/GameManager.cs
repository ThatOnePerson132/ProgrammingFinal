using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public PlayerController pc;

    public float ballsremaining;
    public TextMeshProUGUI RemainingBallsText;

    public float score;
    public TextMeshProUGUI ScoreText;

    public Scorezone[] sz;

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
        ScoreText.SetText("Score: " + score);
        RemainingBallsText.SetText("RemainingBalls: " + ballsremaining);
        
    }
}
