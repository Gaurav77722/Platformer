using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float accumulatedTime;
    private float initialTimerCount = 400f;
    [SerializeField] private TMP_Text timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accumulatedTime += Time.deltaTime;
        if (accumulatedTime > 1f)
        {
            initialTimerCount = initialTimerCount - 1f;
            accumulatedTime = 0f;
            timerText.SetText( "TIME" + "\n" + initialTimerCount.ToString());
        }
        
    }
}
