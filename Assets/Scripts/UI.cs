using System;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject scoreTextTarget;
    [SerializeField] private TextMeshProUGUI timerText;
    
    private void Update()
    {   
        scoreText.transform.position = scoreTextTarget.transform.position;
    }

    public void UpdateScoreUI(int newScore)
    {
        scoreText.text = newScore.ToString();
    }

    public void UpdateTimerUI(int newTime)
    {
        timerText.text = newTime.ToString("00");
    }
}
