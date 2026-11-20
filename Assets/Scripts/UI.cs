using System;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject scoreTextTarget;
    
    private void Update()
    {   
        scoreText.transform.position = scoreTextTarget.transform.position;
    }

    public void UpdateScoreUI(int newScore)
    {
        scoreText.text = newScore.ToString("000");
    }
}
