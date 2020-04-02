using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 temp;
    void Start()
    {
        temp = transform.localScale;
        for (int i = 0; i < 5; i++)
        {
            temp.x += 1f;
        }
        transform.localScale = temp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
