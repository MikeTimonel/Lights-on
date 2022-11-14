using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    BlakkrManager blakkrManager = new BlakkrManager();
    WhalyManagement whalyManager = new WhalyManagement();
    bool isJumping = false;
    private Rigidbody2D rgb2;
    private float powerjump = 7.7f;
    void Start()
    {
        rgb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (gameObject.name == "Player1")
        {
            if (Input.GetKeyDown(blakkrManager.GetJumpKey) && !isJumping)
            {
                rgb2.AddForce(Vector2.up * powerjump, ForceMode2D.Impulse);
                isJumping = true;
            }
        }
        if (gameObject.name == "Player2")
        {
            if (Input.GetKeyDown(whalyManager.GetJumpKey) && !isJumping)
            {
                rgb2.AddForce(Vector2.up * powerjump, ForceMode2D.Impulse);
                isJumping = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            rgb2.velocity = new Vector2(rgb2.velocity.x, 0);
        }
    }
}
