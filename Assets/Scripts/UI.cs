using System;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject scoreTextTarget;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI healthText;
    
    private void Update()
    {   
        scoreText.transform.position = scoreTextTarget.transform.position;
        healthText.transform.position = scoreTextTarget.transform.position;
    }

    public void UpdateScoreUI(int newScore)
    {
        scoreText.text = string.Format("PT: {0}", newScore);
    }

    public void UpdateTimerUI(int newTime)
    {
        timerText.text = string.Format("TIME LEFT: {0}S", newTime);
    }

    public void UpdateHealthUI(int newHealth)
    {
        healthText.text = string.Format("HP: {0}", newHealth);
    }
}
