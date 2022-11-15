using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEvent : MonoBehaviour
{
    public EventManager eventManager;
    public Animator leveranimator;
    public Animator barriersAnimations;
    public BoxCollider2D barriercollider;
    public Animations animations;
    public bool action = false;

    void Start()
    {
        eventManager.OnAction += Open;
    }

    public void Open()
    {
        if (leveranimator.GetBool("On"))
        {
            barriers();
            animations.actionOn();
            leveranimator.SetBool("On", false);
        }
        else if (!leveranimator.GetBool("On"))
        {
            barriers();
            animations.actionOn();
            leveranimator.SetBool("On", true);
        }
    }

    void OnDisable()
    {
        eventManager.OnAction -= Open;
    }
    public void barriers()
    {
        if (barriersAnimations.GetBool("ON"))
        {
            barriersAnimations.SetBool("ON", false);
            barriercollider.enabled = false;
        }
        else if (!barriersAnimations.GetBool("ON"))
        {
            barriersAnimations.SetBool("ON", true);
            barriercollider.enabled = true;
        }
    }
}
