using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Movement movement;
    public Jump jump;
    public bool dead;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            StartCoroutine("reload");
            dead = true;
            Destroy(movement);
            Destroy(jump);
        }
    }
    IEnumerator reload()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Level1");
    }
}
