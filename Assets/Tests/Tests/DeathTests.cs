using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;


public class DeathTests
{
    private Movement movement;
    private Jump jump;
    private GameObject trap;
    private BoxCollider2D collidertrap;
    private Death death;
    private GameObject prefab;
    // A Test behaves as an ordinary method
    [OneTimeSetUp]
    public void SetUp()
    {
        prefab = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        trap = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Fire.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        collidertrap = trap.GetComponent<BoxCollider2D>();
        death = prefab.GetComponentInChildren<Death>();
    }
    [UnityTest]
    public IEnumerator Given_objectwithtagTrap_When_ontriggerenter2D_Then_deadisTrue()
    {
        yield return null;
        Assert.AreEqual(true, death.dead);
    }
    [UnityTest]
    public IEnumerator Given_passtime_When_ontriggerenter2D_Then_loadlevel1()
    {
        yield return death.reload();
        Scene scene = SceneManager.GetActiveScene();
        Assert.AreEqual("Level1", scene.name);
    }
}
