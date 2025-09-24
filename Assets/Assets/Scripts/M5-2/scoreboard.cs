using System;
using UnityEngine;
using TMPro;

public class scoreboard : MonoBehaviour
{
    private TMP_Text textField;
    private int score;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textField = GetComponent<TMP_Text>();
        score = 0;

        textField.text = "Score: ";
        
        pickup.PickedUp += GetPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetPoints(int points)
    {
        score += points;
        textField.text = "score: " + score;
    }
}
