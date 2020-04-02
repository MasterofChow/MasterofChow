using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpbarP1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float player1Hp = 100f;

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
        
    }
}
