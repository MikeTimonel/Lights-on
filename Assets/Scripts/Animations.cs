using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator animations;
    public Movement movement;
    public Death death;
    void FixedUpdate()
    {
        Animationmanagement();
    }
    public void actionOn()
    {
        animations.SetBool("Action", true);
        StartCoroutine("actionOff");
        if (movement != null)
            movement.enabled = false;
    }
    IEnumerator actionOff()
    {
        yield return new WaitForSeconds(.55f);
        animations.SetBool("Action", false);
        if(movement!=null)
            movement.enabled = true;
    }
    public void Animationmanagement()
    {
        if (movement.isrunning == true)
        {
            animations.SetBool("Run", true);
            animations.SetBool("Idle", false);
        }
        else
        {
            animations.SetBool("Run", false);
            animations.SetBool("Idle", true);
        }
        if (death.dead == true)
        {
            animations.SetBool("Death", true);
        }
    }
}
