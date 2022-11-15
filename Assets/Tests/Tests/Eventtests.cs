using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
public class Eventtests
{
    public TestEvent testEvent;
    public GameObject prefab;
    public BoxCollider2D colliderbarrier;
    public GameObject prefabplayer;
    public bool state;
    [SetUp]
    public void Setup()
    {
        prefab = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Lever.prefab"), new Vector3(300, 0, 0), Quaternion.identity);
        prefabplayer = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(300, 0, 0), Quaternion.identity);
        testEvent = prefab.GetComponent<TestEvent>();
        colliderbarrier = prefab.GetComponentInChildren<BoxCollider2D>();
    }
    [UnityTest]
    public IEnumerator Given_barriersOn_When_barriers_Then_colliderbarrierisTrue()
    {
        testEvent.barriersAnimations.SetBool("ON", true);
        testEvent.barriers();
        yield return new WaitForFixedUpdate();
        state = colliderbarrier.enabled;
        Assert.IsTrue(state);
    }
}
