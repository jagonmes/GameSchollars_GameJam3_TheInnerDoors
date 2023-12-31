using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathline : MonoBehaviour
{
    //punto de respawn
    public GameObject respawn;
    public LifesAdministrator lifesScript;
    private bool canTrigger = true;


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canTrigger)
        {
            canTrigger = false;
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.transform.position = respawn.transform.position;
                collision.gameObject.transform.rotation = respawn.transform.rotation;
                lifesScript.LessLifes();
                Invoke("ResetTrigger", 1f);
            }
        }
    }

    private void ResetTrigger()
    {
        canTrigger = true;
    }
}
