using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class CountDown : MonoBehaviour
{
    public static float timeRemaining = 301;  // Tempo inicial em segundos
    TimeSpan timerSpan = TimeSpan.FromSeconds(timeRemaining);
    [SerializeField] TextMeshProUGUI countdownText;  // Referência ao TextMeshPro
    [SerializeField] UnityEvent OnAlarmOn;

    private bool timerIsRunning = false;

    void Start()
    {
        timerIsRunning = true;
        //UpdateTimerText();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timerSpan = TimeSpan.FromSeconds(timeRemaining);
                //UpdateTimerText();
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                //UpdateTimerText();
                OnTimerEnd();
            }

            
            if (timeRemaining <= 91)
            {
                countdownText.color = Color.red;
            }
            countdownText.text = timerSpan.ToString(@"mm\:ss");
        }
    }

    

    void OnTimerEnd()
    {
        Time.timeScale = 0;
        timeRemaining += 301;
    }
}
