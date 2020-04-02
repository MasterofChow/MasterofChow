using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBoxChangerPlayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    public BoxCollider2D player;
    public Animator anim;
    void Start()
    {
        player = player.GetComponent<BoxCollider2D>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.M))
        {
            if (anim.GetBool("lookRight") == true)
            {
                StartCoroutine (RightAttack());
            }
            if (anim.GetBool("lookRight") == false)
            {
                StartCoroutine (LeftAttack());
            }
        }
    }

    IEnumerator RightAttack()
    {
        player.offset = new Vector3(-.20f, 0, 0);
        yield return new WaitForSeconds(.15f);
        player.offset = new Vector3( 0, 0, 0);
    }

    IEnumerator LeftAttack()
    {
        player.offset = new Vector3(.20f, 0, 0);
        yield return new WaitForSeconds(.15f);
        player.offset = new Vector3( 0, 0, 0);
    }
}
