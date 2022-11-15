using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;

public class FinalPlayer2test
{
    public GameObject prefabdoor;
    public GameObject maincamera;
    public FinalLevel finalLevel;
    public bool state;
    public GameObject prefabplayer2;

    [SetUp]
    public void SetUp()
    {
        prefabdoor = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/FinalDoor.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
        finalLevel = GameObject.Find("Main Camera").GetComponent<FinalLevel>();
        prefabplayer2 = MonoBehaviour.Instantiate(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Whaly.prefab"), new Vector3(0, 0, 0), Quaternion.identity);
    }
    [UnityTest]
    public IEnumerator Given_tagplayer2_When_ontriggercollider2d_Then_player2finished()
    {
        state = finalLevel.player2F;
        Assert.IsTrue(state);
        yield return null;
    }
    [UnityTest]
    public IEnumerator Given_tagplayer2_When_ontriggercollider2dexit_Then_player2notfinished()
    {
        prefabplayer2.SetActive(false);
        yield return new WaitForFixedUpdate();
        state = finalLevel.player2F;
        Assert.IsFalse(state);
    }
}
