using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerlevel;
    public Text TimerTxt;
    public Death death;
    public FinalLevel final;
    public Death death2;
    void FixedUpdate()
    {
        if (!death.dead && !death2.dead && !final.finished)
        {
            timerlevel += Time.deltaTime;
            var timeSpan = TimeSpan.FromSeconds(timerlevel);
            TimerTxt.text = string.Format("{0:D1}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        }
        else if (final.finished)
            Destroy(gameObject);         
    }
}
