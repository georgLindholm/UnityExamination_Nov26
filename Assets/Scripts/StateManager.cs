using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        
        Scoring.score = 0;
    }

    public void EndGame()
    {
        SceneManager.LoadScene("DeathScene");
    }
}
