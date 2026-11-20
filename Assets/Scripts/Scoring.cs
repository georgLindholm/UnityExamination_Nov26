using UnityEngine;

public class Scoring : MonoBehaviour
{
    [SerializeField] private UI UiHandler;
    
    private int score = 0;
    
    public void IncrementScore()
    {
        score++;
        
        UiHandler.UpdateScoreUI(score);
    }
}
