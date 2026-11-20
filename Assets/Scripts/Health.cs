using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public UnityEvent onDeath;
    
    [SerializeField] private UI UiHandler;
    
    private int health = 3;

    public void TakeDamage()
    {
        health--;

        UiHandler.UpdateHealthUI(health);
        
        if (health <= 0)
        {
            onDeath.Invoke();
        }
    }
}
