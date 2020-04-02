using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateDaggerHBONE : MonoBehaviour
{
    private bool attacking = false;

    private bool direction = true;

    private float attackTimer = 0;
    private float attackCoolDown = .15f;

    public Collider2D daggerHBr;
    public Collider2D daggerHBl;

    public GameObject daggerR;

    public GameObject daggerL;

    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        // daggerHBr.enabled = false;
        // daggerHBl.enabled = false;
        daggerR.SetActive(false);
        daggerL.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.T) && !attacking)
        {
            attacking = true;
            attackTimer = attackCoolDown;

            direction = anim.GetBool("lookRight");
            if (direction == true)
            {
                // daggerHBr.enabled = true;
                daggerR.SetActive(true);
                Debug.Log("daggerHBr enabled");
            }
            else if (direction == false)
            {
                // daggerHBl.enabled = true;
                daggerL.SetActive(true);
                Debug.Log("daggerHBl enabled");
            }
        }

        // Debug.Log(attacking);

        if (attacking == true)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                // daggerHBr.enabled = false;
                // daggerHBl.enabled = false;
                daggerR.SetActive(false);
                daggerL.SetActive(false);
            }
        }
    }
}
