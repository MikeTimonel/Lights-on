using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

public class Movementtests
{
    public GameObject prefab;
    public GameObject prefab2;
    public Movement movement;
    public Movement movement2;
    public bool state;

    [SetUp]
    public void SetUp()
    {
        prefab = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        prefab2 = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Whaly.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        movement = prefab.GetComponentInChildren<Movement>();
        movement2 = prefab2.GetComponentInChildren<Movement>();
        movement.testing2 = true;
    }
    [UnityTest]
    public IEnumerator Given_Inputrightkey_When_movementfixedUpdate_Then_spriteflipxFalse()
    {
        state = movement.mySpriteRenderer.flipX;
        Assert.IsFalse(state);
        yield return null;
    }
    [UnityTest]
    public IEnumerator Given_Inputleftkey_When_movementfixedUpdate_Then_spriteflipxTrue()
    {
        state = movement2.mySpriteRenderer.flipX;
        Assert.IsTrue(state);
        yield return null;
    }
}
