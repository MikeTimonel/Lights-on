using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

public class Animationsdeathtest
{
    private Animator animator;
    private Animations animations;
    private Death death;
    private bool state;

    private GameObject prefab;

    [SetUp]
    public void Setup()
    {
        prefab = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        animations = prefab.GetComponentInChildren<Animations>();
        animator = prefab.GetComponent<Animator>();
        death = prefab.GetComponentInChildren<Death>();
        death.dead = true;
    }
    [UnityTest]
    public IEnumerator Give_dead_When_actionmanagement_Then_deathstateanimatoristrue()
    {
        state = animator.GetBool("Death");
        Assert.AreEqual(true, state);
        yield return null;
    }
}
