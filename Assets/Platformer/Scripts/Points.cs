using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public TMP_Text score;
    private GameObject mario;

    public int points;
    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void scoreInc()
    {
        points = points + 100;
        score.SetText("MARIO" + "           " + "           WORLD" + "\n" + points.ToString() + "                   1-1");
    }
}
