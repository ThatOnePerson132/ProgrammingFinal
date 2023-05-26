using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public PlayerController pc;

    public float score;
    public TextMeshProUGUI ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.SetText("Score: " + score);
    }
}
