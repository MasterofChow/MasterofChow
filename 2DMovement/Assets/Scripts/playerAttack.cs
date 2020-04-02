using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateDaggerHB1 : MonoBehaviour
{
    private bool attacking = false;

    private float attackTimer = 0;
    private float attackCoolDown = .3f;

    public Collider2D triggerAttack;

    private Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        triggerAttack.enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.T) && !attacking)
        {
            attacking = true;
            attackTimer = attackCoolDown;

            triggerAttack.enabled = true;
        }

        if (attacking == true)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                triggerAttack.enabled = false;
            }
        }
    }
}
