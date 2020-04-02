using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Howdy");
        Application.LoadLevel("Fighting Stage");
    }
}
