using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daggerHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "BlueGladiator")
        {
            Debug.Log("hit");
            hpbarP2.player2HP = hpbarP2.player2HP - 10; 
            Debug.Log(hpbarP2.player2HP);
        }
    }
}