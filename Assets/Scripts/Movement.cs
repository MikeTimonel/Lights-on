using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    BlakkrManager blakkrManager = new BlakkrManager();
    WhalyManagement whalyManager = new WhalyManagement();
    public SpriteRenderer mySpriteRenderer;
    public bool testing = false;
    public bool testing2 = false;
    public bool isrunning;
    bool flip;
    private const float speed = 3.8f;
    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        Vector3 position = transform.position;
        if (gameObject.name == "Player1")
        {
            if ((Input.GetKey(blakkrManager.GetLeftKey)) || testing)
            {
                position.x -= speed * Time.deltaTime;
                mySpriteRenderer.flipX = true;
                isrunning = true;
            }
            else if ((Input.GetKey(blakkrManager.GetRightKey)) || testing2)
            {
                position.x += speed * Time.deltaTime;
                mySpriteRenderer.flipX = false;
                isrunning = true;
            }
            else
                isrunning = false;
            transform.position = position;
        }
        if (gameObject.name == "Player2")
        {
            if ((Input.GetKey(whalyManager.GetLeftKey)) || testing)
            {
                position.x -= speed * Time.deltaTime;
                mySpriteRenderer.flipX = true;
                isrunning = true;
            }
            else if ((Input.GetKey(whalyManager.GetRightKey)) || testing)
            {
                position.x += speed * Time.deltaTime;
                mySpriteRenderer.flipX = false;
                isrunning = true;
            }
            else
                isrunning = false;
            transform.position = position;
        }
    }

}