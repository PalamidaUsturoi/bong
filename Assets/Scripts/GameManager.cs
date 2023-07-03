using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private BallScript ball;
    [SerializeField] private GameBoundaries borderLeft;
    [SerializeField] private GameBoundaries borderRight;
    [SerializeField] private Player playerLeft;
    [SerializeField] private Player playerRight;
    [SerializeField] private GameObject scoreObj;
    private int lastHolder;
    private int[] score = new int[2];

    void Start()
    {
        borderLeft.OnCollision += (Collision2D col) => GameOver();
        borderRight.OnCollision += (Collision2D col) => GameOver();
        playerLeft.OnCollision += (Collision2D col) => UpdateLastHolder(1);
        playerRight.OnCollision += (Collision2D col) => UpdateLastHolder(2);
        lastHolder = 0;
        score[0] = score[1] = 0;
    }

    void GameOver()
    {
        UpdateScore();
        ball.ResetBall();
    }

    void UpdateLastHolder (int index)
    {
        lastHolder = index;
    }

    private void UpdateScore()
    {
        if ( lastHolder != 0 )
        {
            score[lastHolder - 1] ++;
            scoreObj.GetComponent<TMP_Text>().text = "Score: " + score[0] + "-" + score[1];
        }
        else
        {
            score[2 - ball.sens]++;
            scoreObj.GetComponent<TMP_Text>().text = "Score: " + score[0] + "-" + score[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
