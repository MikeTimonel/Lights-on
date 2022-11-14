using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPlayer : MonoBehaviour
{
    FinalLevel finalLevel;

    void Start()
    {
        finalLevel = GameObject.Find("Main Camera").GetComponent<FinalLevel>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player1")
            finalLevel.player1F = true;
        if (collider.gameObject.name == "Player2")
            finalLevel.player2F = true;
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player1")
            finalLevel.player1F = false;
        if (collider.gameObject.name == "Player2")
            finalLevel.player2F = false;
    }
}
