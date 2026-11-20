using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public UnityEvent onTimeout;
    
    [SerializeField] private UI UiHandler;

    private int timer = 30;

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    public void AddTime()
    {
        timer += 2;
        
        UiHandler.UpdateTimerUI(timer);
    }
    
    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1f);

        timer--;
        
        UiHandler.UpdateTimerUI(timer);

        if (timer > 0)
        {
            StartCoroutine(Countdown());
        }
        else
        {
            onTimeout.Invoke();
        }
    }
}
