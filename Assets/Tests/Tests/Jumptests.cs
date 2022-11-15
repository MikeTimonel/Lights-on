using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

public class Jumptests
{
    private GameObject prefab;
    BlakkrManager blakkrManager = new BlakkrManager();
    private Jump jump;
    private bool state;
    [SetUp]
    public void Setup()
    {
        prefab = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        jump = prefab.GetComponentInChildren<Jump>();
        jump.isJumping = false;
    } 
    [UnityTest]
    public IEnumerator Given_isnotjumping_When_passtime_Then_isjumpingFalse()
    {
        Input.GetKeyDown(blakkrManager.GetJumpKey);
        state = jump.isJumping;
        Assert.IsFalse(state);
        yield return new WaitForFixedUpdate();
    }
}
