using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalLevel : MonoBehaviour
{
    public bool player1F = false;
    public bool player2F = false;
    public Animator canvaanimator;
    public Movement mo1;
    public Text timerfinal;
    public Movement mo2;
    public float finaltime;
    public bool finished;
    public Timer timer;

    void Update()
    {
        if (player2F && player1F)
        {
            finished = true;
            canvaanimator.enabled = true;
            Destroy(mo1);
            Destroy(mo2);
            StartCoroutine("destroyscript");
        }
    }
    IEnumerator destroyscript()
    {
        yield return new WaitForSeconds(0.66f);
        finaltime = timer.timerlevel;
        var timeSpan = TimeSpan.FromSeconds(finaltime);
        timerfinal.text = string.Format("{0:D1}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        yield return new WaitForSeconds(0.33f);
        Destroy(this);
    }
}
