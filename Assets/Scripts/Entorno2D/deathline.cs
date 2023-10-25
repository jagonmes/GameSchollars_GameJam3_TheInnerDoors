using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathline : MonoBehaviour
{
    //punto de respawn
    public GameObject respawn;
    //contador de vidas
    private int lifesCounter;


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = respawn.transform.position;
            
        }
    }
}
