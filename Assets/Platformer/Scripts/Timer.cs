using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float accumulatedTime;
    private float initialTimerCount = 100f;
    [SerializeField] private TMP_Text timerText;
    
    
    // Update is called once per frame
    void Update()
    {
        accumulatedTime += Time.deltaTime;
        if (accumulatedTime > 1f && initialTimerCount!=0)
        {
            initialTimerCount = initialTimerCount - 1f;
            accumulatedTime = 0f;
            timerText.SetText( "TIME" + "\n" + initialTimerCount.ToString());
        }

        if (initialTimerCount < 1f)
        {
            Debug.Log("YOU LOST!");
        }

    }
}
