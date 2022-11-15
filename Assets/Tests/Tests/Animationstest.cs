using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

public class Animationstest {

    private Animator animator;
    private Animations animations;
    private Movement movement;
    private bool state;
    private GameObject prefab;
    [SetUp]
    public void Setup()
    {
        prefab = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        animations = prefab.GetComponentInChildren<Animations>();
        animator = prefab.GetComponent<Animator>();
        movement = prefab.GetComponentInChildren<Movement>();
        movement.testing = true;
    }
    [UnityTest]
    public IEnumerator Give_isrunning_When_actionmanagement_Then_runstateanimatoristrue()
    {
        yield return null;
        state = animator.GetBool("Run");
        Assert.AreEqual(true, state);
    }
    [UnityTest]
    public IEnumerator Give_isrunning_When_actionmanagement_Then_idlestateanimatorisfalse()
    {
        yield return new WaitForFixedUpdate();
        state = animator.GetBool("Idle");
        Assert.AreEqual(false, state);
    }
}
