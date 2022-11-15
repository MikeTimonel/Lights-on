using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

public class Actiontests
{
    private Animations animations;
    private Animator animator;
    private bool state;
    private Movement movement;
    private GameObject prefab;
    [SetUp]
    public void SetUp()
    {
        prefab = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        animator = prefab.GetComponent<Animator>();
        animations = prefab.GetComponentInChildren<Animations>();
    }
    [Test]
    public void Given_action_When_actionOn_Then_actionstateistrue()
    {
        animations.actionOn();
        state = animator.GetBool("Action");
        Assert.AreEqual(true, state);
    }
    [Test]
    public void Given_movementisnotnull_When_actionOn_Then_movementisnotenabled()
    {
        movement = prefab.GetComponentInChildren<Movement>();
        animations.actionOn();
        state = movement.enabled;
        Assert.AreEqual(false, state);
    }
    [UnityTest]
    public IEnumerator Given_passtime_When_actionOn_Then_actionstateisfalse()
    {
        animations.actionOn();
        yield return animations.StartCoroutine("actionOff");
        state = animator.GetBool("Action");
        Assert.AreEqual(false, state);
    }
    [UnityTest]
    public IEnumerator Given_passtime_When_actionOn_Then_movementisenabled()
    {
        movement = prefab.GetComponentInChildren<Movement>();
        animations.actionOn();
        yield return animations.StartCoroutine("actionOff");
        state = movement.enabled;
        Assert.AreEqual(true, state);
    }
}
