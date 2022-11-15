using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

public class Finalplayertests
{
    public GameObject prefabplayer1;
    public GameObject prefabdoor;
    public GameObject maincamera;
    public FinalLevel finalLevel;
    public bool state;

    [SetUp]
    public void SetUp()
    {
        prefabdoor = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/FinalDoor.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        finalLevel = GameObject.Find("Main Camera").GetComponent<FinalLevel>(); 
        prefabplayer1 = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Blakkr.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
    }
    [UnityTest]
    public IEnumerator Given_tagplayer1_When_ontriggercollider2d_Then_player1finished()
    { 
        state = finalLevel.player1F;
        Assert.IsTrue(state);
        yield return null;
    }
    [UnityTest]
    public IEnumerator Given_tagplayer1_When_ontriggercollider2dexit_Then_player1notfinished()
    {
        prefabplayer1.SetActive(false);
        state = finalLevel.player1F;
        yield return null;
        Assert.IsFalse(state);
    }
}
