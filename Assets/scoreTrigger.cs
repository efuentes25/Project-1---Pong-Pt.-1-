using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTrigger : MonoBehaviour
{
    private int player1Count = 0;
    private int player2Count = 0;

    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log($"Player 1 Score: {player1Count}");
        Debug.Log($"Player 2 Score: {player2Count}");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "Trigger1")
        {
            player1Count += 1;
            Debug.Log($"Player 1 scored. Score: {player1Count}");
        }

        if (gameObject.name == "Trigger2")
        {
            player2Count += 1;
            Debug.Log($"Player 2 scored. Score: {player2Count}");
        }

        if (gameObject.name == "Trigger1" && player1Count == 11)
        {
            Debug.Log($"Game Over Player 1 has won. ");
            player1Count = 0;
            player2Count = 0;
            Time.timeScale = 0.0f;
        }
        else if(gameObject.name == "Trigger2" && player2Count == 11)
        {
            Debug.Log($"Game Over Player 2 has won. ");
            player1Count = 0;
            player2Count = 0;
            Time.timeScale = 0.0f;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
}
