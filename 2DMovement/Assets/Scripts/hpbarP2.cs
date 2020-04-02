using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpbarP2 : MonoBehaviour
{
    // Start is called before the first frame update
    public static float player2HP = 100f;

    Vector3 temp;

    bool scale = true;
    void Start()
    {
        temp = transform.localScale;
        for (int i = 0; i < 5; i++)
        {
            // Debug.Log(i);
            temp.x += 1;
        }
        transform.localScale = temp;
    }

    // Update is called once per frame
    void Update()
    {
        if (player2HP >= 0)
        {
            
            if (player2HP == 0)
            {
                Debug.Log("Game Over");
                Debug.Log("Player 1 Wins");
            }
        }
    }
}
