using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

public class Animationnoruntests
{
    private Animator animator;
    private Animations animations;
    private GameObject player;
    private Movement movement;
    private Death death;
    private bool state;

    private GameObject prefab;

    [SetUp]
    public void Setup()
    {
        prefab = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        animations = prefab.GetComponentInChildren<Animations>();
        animator = prefab.GetComponent<Animator>();
        movement = prefab.GetComponentInChildren<Movement>();
        death = prefab.GetComponentInChildren<Death>();
        movement.testing = false;
    }
    [UnityTest]
    public IEnumerator Give_isnotrunning_When_actionmanagement_Then_idlestateanimatoristrue()
    { 
        state = animator.GetBool("Idle");
        Assert.AreEqual(true, state);
        yield return null;
    }
    [UnityTest]
    public IEnumerator Give_isnotrunning_When_actionmanagement_Then_runstateanimatorisfalse()
    {
        state = animator.GetBool("Run");
        Assert.AreEqual(false, state);
        yield return null;
    }
    
}
