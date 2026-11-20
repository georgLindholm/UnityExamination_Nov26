using UnityEngine;

public class Health : MonoBehaviour
{
    private int health = 3;

    public void TakeDamage()
    {
        health--;
    }
}
